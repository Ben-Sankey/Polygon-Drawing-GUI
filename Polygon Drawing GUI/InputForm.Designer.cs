namespace Polygon_Drawing_GUI
{
    partial class InputForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            SideInput = new NumericUpDown();
            RadiusBox = new NumericUpDown();
            GenerateButton = new Button();
            SidesLabel = new Label();
            RadiusLable = new Label();
            InfoImage = new PictureBox();
            PolygonDrawerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SideInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadiusBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoImage).BeginInit();
            SuspendLayout();
            // 
            // SideInput
            // 
            SideInput.Font = new Font("Segoe UI", 20F);
            SideInput.Location = new Point(369, 541);
            SideInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SideInput.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            SideInput.Name = "SideInput";
            SideInput.Size = new Size(347, 61);
            SideInput.TabIndex = 0;
            SideInput.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // RadiusBox
            // 
            RadiusBox.Font = new Font("Segoe UI", 20F);
            RadiusBox.Location = new Point(12, 541);
            RadiusBox.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            RadiusBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RadiusBox.Name = "RadiusBox";
            RadiusBox.Size = new Size(341, 61);
            RadiusBox.TabIndex = 1;
            RadiusBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // GenerateButton
            // 
            GenerateButton.Font = new Font("Segoe UI", 20F);
            GenerateButton.Location = new Point(12, 608);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(704, 74);
            GenerateButton.TabIndex = 2;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            // 
            // SidesLabel
            // 
            SidesLabel.AutoSize = true;
            SidesLabel.Font = new Font("Segoe UI", 14F);
            SidesLabel.Location = new Point(369, 500);
            SidesLabel.Name = "SidesLabel";
            SidesLabel.Size = new Size(152, 38);
            SidesLabel.TabIndex = 3;
            SidesLabel.Text = "Side Count";
            SidesLabel.Click += SidesLabel_Click;
            // 
            // RadiusLable
            // 
            RadiusLable.AutoSize = true;
            RadiusLable.Font = new Font("Segoe UI", 14F);
            RadiusLable.Location = new Point(12, 500);
            RadiusLable.Name = "RadiusLable";
            RadiusLable.Size = new Size(99, 38);
            RadiusLable.TabIndex = 4;
            RadiusLable.Text = "Radius";
            // 
            // InfoImage
            // 
            InfoImage.Image = (Image)resources.GetObject("InfoImage.Image");
            InfoImage.InitialImage = (Image)resources.GetObject("InfoImage.InitialImage");
            InfoImage.Location = new Point(139, 76);
            InfoImage.Name = "InfoImage";
            InfoImage.Size = new Size(425, 425);
            InfoImage.TabIndex = 5;
            InfoImage.TabStop = false;
            // 
            // PolygonDrawerLabel
            // 
            PolygonDrawerLabel.AutoSize = true;
            PolygonDrawerLabel.Font = new Font("Segoe UI", 20F);
            PolygonDrawerLabel.Location = new Point(198, 19);
            PolygonDrawerLabel.Name = "PolygonDrawerLabel";
            PolygonDrawerLabel.Size = new Size(303, 54);
            PolygonDrawerLabel.TabIndex = 6;
            PolygonDrawerLabel.Text = "Polygon Drawer";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 694);
            Controls.Add(PolygonDrawerLabel);
            Controls.Add(InfoImage);
            Controls.Add(RadiusLable);
            Controls.Add(SidesLabel);
            Controls.Add(GenerateButton);
            Controls.Add(RadiusBox);
            Controls.Add(SideInput);
            Name = "InputForm";
            Text = "Polygon Drawer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SideInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadiusBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown SideInput;
        private NumericUpDown RadiusBox;
        private Button GenerateButton;
        private Label SidesLabel;
        private Label RadiusLable;
        private PictureBox InfoImage;
        private Label PolygonDrawerLabel;
    }
}
