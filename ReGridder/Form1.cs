using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReGridder
{
    public partial class frmBase : Form
    {
        public Bitmap BaseImage;

        public frmBase()
        {
            InitializeComponent();
        }


        // --- ERROR CHECK FUNCTIONS ---
        public string ComputeErrorMessage(bool[] conditions, string[] messages)
        {
            string message = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    try
                    {
                        message += messages[i] + "\n";
                    }
                    catch (IndexOutOfRangeException error)
                    {
                        message += $"ERROR for condition {i}" + "\n";
                    }
                }
            }
            return message;
        }

        public bool CanRegridCheck()
        {
            bool[] errorConditions = {
                BaseImage == null,
                numBaseHeight.Value == numTargetHeight.Value && numBaseWidth.Value == numTargetWidth.Value
            };

            string[] errorMessages = {
                "- No Image Loaded",
                "- Base And Target Cell Size Are Equal"
            };

            string errorMessage = ComputeErrorMessage(errorConditions, errorMessages);

            if (String.IsNullOrEmpty(errorMessage)) return true;
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            }
        }




        // --- IMAGE LOAD/SAVE FUNCTIONS ---
        public void SelectImage()
        {
            if (ofdImageSelect.ShowDialog() == DialogResult.OK)
            {
                BaseImage = new Bitmap(ofdImageSelect.FileName);
                picBaseImage.Image = BaseImage;
            }
        }

        public void SaveImage()
        {
            if (sfdImage.ShowDialog() == DialogResult.OK && sfdImage.FileName != "")
            {
                picResultImage.Image.Save(sfdImage.FileName);
            }
        }




        // --- IMAGE FUNCTIONS ---
        public void ComputeTopRightPadding()
        {
            int baseCellWidth = (int)numBaseWidth.Value;
            int baseCellHeight = (int)numBaseHeight.Value;

            int maxX = -1;
            int minY = 0;
            bool hasMinY = false;

            for (int cellY = 0; cellY < BaseImage.Height / baseCellHeight; cellY++)
            {
                for (int cellX = 0; cellX < BaseImage.Width / baseCellWidth; cellX++)
                {
                    for (int y = 0; y < baseCellHeight; y++)
                    {
                        for (int x = baseCellWidth - 1; x >= 0; x--)
                        {
                            if (x <= maxX) break;

                            if (BaseImage.GetPixel(x + cellX * baseCellWidth, y + cellY * baseCellHeight).A != 0)
                            {
                                if (x > maxX) maxX = x;

                                if (!hasMinY)
                                {
                                    hasMinY = true;
                                    minY = y;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            numTargetWidth.Value = maxX + 1;
            numTargetHeight.Value = baseCellHeight - minY;
        }

        public void Regrid()
        {
            // Input Cells Size
            int baseCellWidth = (int)numBaseWidth.Value;
            int baseCellHeight = (int)numBaseHeight.Value;
            int targetCellWidth = (int)numTargetWidth.Value;
            int targetCellHeight = (int)numTargetHeight.Value;

            int numColumns = BaseImage.Width / baseCellWidth;
            int numRows = BaseImage.Height / baseCellHeight;

            // Result Image
            Bitmap regridImage = new Bitmap(numColumns * targetCellWidth, numRows * targetCellHeight);

            // Sample and draw the smallest amount of pixels
            int sampleWidth = Math.Min(baseCellWidth, targetCellWidth);
            int sampleHeight = Math.Min(baseCellHeight, targetCellHeight);

            int sampleOffsetY = Math.Max(0, baseCellHeight - targetCellHeight); //crop from the upper bounds of the cell, skip the first sampleOffsetY pixels
            int drawOffsetY = Math.Max(0, targetCellHeight - baseCellHeight);

            for (int row = 0; row < numRows; row++)
            {
                int baseCellY = row * baseCellHeight + sampleOffsetY;
                int targetCellY = row * targetCellHeight + drawOffsetY;

                for (int column = 0; column < numColumns; column++)
                {
                    int baseCellX = column * baseCellWidth;
                    int targetCellX = column * targetCellWidth;

                    for (int y = 0; y < sampleHeight; y++)
                    {
                        for (int x = 0; x < sampleWidth; x++)
                        {
                            Color c = BaseImage.GetPixel(x + baseCellX, y + baseCellY);
                            regridImage.SetPixel(x + targetCellX, y + targetCellY, c);
                        }
                    }
                }
            }
            picResultImage.Image = regridImage;
        }

        public void RemoveTopRightPadding()
        {
            if (CanRegridCheck())
            {
                ComputeTopRightPadding();
                Regrid();
            }
        }




        // --- FORM CONTROLS EVENTS ---
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            SelectImage();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveImage();
        }


        private void btnRegrid_Click(object sender, EventArgs e)
        {
            if (CanRegridCheck())
            {
                Regrid();
            }
        }

        private void btnRemovePadding_Click(object sender, EventArgs e)
        {
            RemoveTopRightPadding();
        }
    }
}
