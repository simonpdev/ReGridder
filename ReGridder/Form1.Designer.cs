namespace ReGridder
{
    partial class frmBase
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdImageSelect = new System.Windows.Forms.OpenFileDialog();
            this.picBaseImage = new System.Windows.Forms.PictureBox();
            this.picResultImage = new System.Windows.Forms.PictureBox();
            this.numTargetWidth = new System.Windows.Forms.NumericUpDown();
            this.numTargetHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numBaseHeight = new System.Windows.Forms.NumericUpDown();
            this.numBaseWidth = new System.Windows.Forms.NumericUpDown();
            this.btnRegrid = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnRemovePadding = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBaseSettings = new System.Windows.Forms.GroupBox();
            this.grpTargetSettings = new System.Windows.Forms.GroupBox();
            this.sfdImage = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseWidth)).BeginInit();
            this.grpBaseSettings.SuspendLayout();
            this.grpTargetSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImageSelect
            // 
            this.ofdImageSelect.Filter = "Images (*.png)|*.png";
            this.ofdImageSelect.Title = "Select an image";
            // 
            // picBaseImage
            // 
            this.picBaseImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBaseImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBaseImage.Location = new System.Drawing.Point(47, 53);
            this.picBaseImage.Margin = new System.Windows.Forms.Padding(2);
            this.picBaseImage.Name = "picBaseImage";
            this.picBaseImage.Size = new System.Drawing.Size(388, 150);
            this.picBaseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBaseImage.TabIndex = 0;
            this.picBaseImage.TabStop = false;
            // 
            // picResultImage
            // 
            this.picResultImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picResultImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResultImage.Location = new System.Drawing.Point(47, 272);
            this.picResultImage.Margin = new System.Windows.Forms.Padding(2);
            this.picResultImage.Name = "picResultImage";
            this.picResultImage.Size = new System.Drawing.Size(388, 150);
            this.picResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picResultImage.TabIndex = 1;
            this.picResultImage.TabStop = false;
            // 
            // numTargetWidth
            // 
            this.numTargetWidth.Location = new System.Drawing.Point(21, 46);
            this.numTargetWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numTargetWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numTargetWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTargetWidth.Name = "numTargetWidth";
            this.numTargetWidth.Size = new System.Drawing.Size(90, 20);
            this.numTargetWidth.TabIndex = 2;
            this.numTargetWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numTargetHeight
            // 
            this.numTargetHeight.Location = new System.Drawing.Point(24, 93);
            this.numTargetHeight.Margin = new System.Windows.Forms.Padding(2);
            this.numTargetHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numTargetHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTargetHeight.Name = "numTargetHeight";
            this.numTargetHeight.Size = new System.Drawing.Size(90, 20);
            this.numTargetHeight.TabIndex = 3;
            this.numTargetHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width";
            // 
            // numBaseHeight
            // 
            this.numBaseHeight.Location = new System.Drawing.Point(21, 93);
            this.numBaseHeight.Margin = new System.Windows.Forms.Padding(2);
            this.numBaseHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numBaseHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseHeight.Name = "numBaseHeight";
            this.numBaseHeight.Size = new System.Drawing.Size(90, 20);
            this.numBaseHeight.TabIndex = 7;
            this.numBaseHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numBaseWidth
            // 
            this.numBaseWidth.Location = new System.Drawing.Point(21, 46);
            this.numBaseWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numBaseWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numBaseWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseWidth.Name = "numBaseWidth";
            this.numBaseWidth.Size = new System.Drawing.Size(90, 20);
            this.numBaseWidth.TabIndex = 6;
            this.numBaseWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // btnRegrid
            // 
            this.btnRegrid.Location = new System.Drawing.Point(541, 379);
            this.btnRegrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegrid.Name = "btnRegrid";
            this.btnRegrid.Size = new System.Drawing.Size(290, 43);
            this.btnRegrid.TabIndex = 10;
            this.btnRegrid.Text = "REGRID";
            this.btnRegrid.UseVisualStyleBackColor = true;
            this.btnRegrid.Click += new System.EventHandler(this.btnRegrid_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(541, 236);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(290, 43);
            this.btnSelectImage.TabIndex = 11;
            this.btnSelectImage.Text = "LOAD IMAGE";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(541, 332);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(290, 43);
            this.btnSaveImage.TabIndex = 12;
            this.btnSaveImage.Text = "SAVE IMAGE";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnRemovePadding
            // 
            this.btnRemovePadding.Location = new System.Drawing.Point(541, 283);
            this.btnRemovePadding.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePadding.Name = "btnRemovePadding";
            this.btnRemovePadding.Size = new System.Drawing.Size(290, 45);
            this.btnRemovePadding.TabIndex = 13;
            this.btnRemovePadding.Text = "REMOVE TOP + RIGHT PADDING \r\n(requires correct base cell size)\r\n";
            this.btnRemovePadding.UseVisualStyleBackColor = true;
            this.btnRemovePadding.Click += new System.EventHandler(this.btnRemovePadding_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Base Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Result";
            // 
            // grpBaseSettings
            // 
            this.grpBaseSettings.Controls.Add(this.numBaseHeight);
            this.grpBaseSettings.Controls.Add(this.numBaseWidth);
            this.grpBaseSettings.Controls.Add(this.label4);
            this.grpBaseSettings.Controls.Add(this.label3);
            this.grpBaseSettings.Location = new System.Drawing.Point(541, 53);
            this.grpBaseSettings.Name = "grpBaseSettings";
            this.grpBaseSettings.Size = new System.Drawing.Size(131, 131);
            this.grpBaseSettings.TabIndex = 16;
            this.grpBaseSettings.TabStop = false;
            this.grpBaseSettings.Text = "Base Cell Size";
            // 
            // grpTargetSettings
            // 
            this.grpTargetSettings.Controls.Add(this.numTargetWidth);
            this.grpTargetSettings.Controls.Add(this.label1);
            this.grpTargetSettings.Controls.Add(this.numTargetHeight);
            this.grpTargetSettings.Controls.Add(this.label2);
            this.grpTargetSettings.Location = new System.Drawing.Point(700, 53);
            this.grpTargetSettings.Name = "grpTargetSettings";
            this.grpTargetSettings.Size = new System.Drawing.Size(131, 131);
            this.grpTargetSettings.TabIndex = 17;
            this.grpTargetSettings.TabStop = false;
            this.grpTargetSettings.Text = "Target Cell Size";
            // 
            // sfdImage
            // 
            this.sfdImage.Filter = "Images (*.png)|*.png";
            this.sfdImage.Title = "Save Image";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 466);
            this.Controls.Add(this.grpTargetSettings);
            this.Controls.Add(this.grpBaseSettings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemovePadding);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnRegrid);
            this.Controls.Add(this.picResultImage);
            this.Controls.Add(this.picBaseImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.Text = "ReGridder";
            ((System.ComponentModel.ISupportInitialize)(this.picBaseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseWidth)).EndInit();
            this.grpBaseSettings.ResumeLayout(false);
            this.grpBaseSettings.PerformLayout();
            this.grpTargetSettings.ResumeLayout(false);
            this.grpTargetSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImageSelect;
        private System.Windows.Forms.PictureBox picBaseImage;
        private System.Windows.Forms.PictureBox picResultImage;
        private System.Windows.Forms.NumericUpDown numTargetWidth;
        private System.Windows.Forms.NumericUpDown numTargetHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBaseHeight;
        private System.Windows.Forms.NumericUpDown numBaseWidth;
        private System.Windows.Forms.Button btnRegrid;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnRemovePadding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBaseSettings;
        private System.Windows.Forms.GroupBox grpTargetSettings;
        private System.Windows.Forms.SaveFileDialog sfdImage;
    }
}

