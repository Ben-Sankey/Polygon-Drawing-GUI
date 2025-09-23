namespace Polygon_Drawing_GUI
{
    partial class DisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiamaterLabel = new Label();
            RadiusLabel = new Label();
            ApothemLabel = new Label();
            SidesLabel = new Label();
            SideLengthLabel = new Label();
            DiagonalsLabel = new Label();
            PerimiterLabel = new Label();
            AreaLabel = new Label();
            TriangleAreaLabel = new Label();
            InternalAngleLabel = new Label();
            ExternalAngleLabel = new Label();
            InteriorAngleSumLabel = new Label();
            ExteriorAngleSumLabel = new Label();
            CoordinatesLabel = new Label();
            PolygonLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label1 = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            RegenerateButton = new Button();
            PlotCoordsButton = new Button();
            SuspendLayout();
            // 
            // DiamaterLabel
            // 
            DiamaterLabel.AutoSize = true;
            DiamaterLabel.Font = new Font("Segoe UI", 12F);
            DiamaterLabel.Location = new Point(12, 205);
            DiamaterLabel.Name = "DiamaterLabel";
            DiamaterLabel.Size = new Size(111, 32);
            DiamaterLabel.TabIndex = 1;
            DiamaterLabel.Text = "Diamater";
            DiamaterLabel.Click += this.DiamaterLabel_Click;
            // 
            // RadiusLabel
            // 
            RadiusLabel.AutoSize = true;
            RadiusLabel.Font = new Font("Segoe UI", 12F);
            RadiusLabel.Location = new Point(12, 301);
            RadiusLabel.Name = "RadiusLabel";
            RadiusLabel.Size = new Size(84, 32);
            RadiusLabel.TabIndex = 2;
            RadiusLabel.Text = "Radius";
            RadiusLabel.Click += this.RadiusLabel_Click;
            // 
            // ApothemLabel
            // 
            ApothemLabel.AutoSize = true;
            ApothemLabel.Font = new Font("Segoe UI", 12F);
            ApothemLabel.Location = new Point(12, 399);
            ApothemLabel.Name = "ApothemLabel";
            ApothemLabel.Size = new Size(113, 32);
            ApothemLabel.TabIndex = 3;
            ApothemLabel.Text = "Apothem";
            ApothemLabel.Click += this.ApothemLabel_Click;
            // 
            // SidesLabel
            // 
            SidesLabel.AutoSize = true;
            SidesLabel.Font = new Font("Segoe UI", 12F);
            SidesLabel.Location = new Point(186, 205);
            SidesLabel.Name = "SidesLabel";
            SidesLabel.Size = new Size(70, 32);
            SidesLabel.TabIndex = 4;
            SidesLabel.Text = "Sides";
            SidesLabel.Click += this.SidesLabel_Click;
            // 
            // SideLengthLabel
            // 
            SideLengthLabel.AutoSize = true;
            SideLengthLabel.Font = new Font("Segoe UI", 12F);
            SideLengthLabel.Location = new Point(186, 301);
            SideLengthLabel.Name = "SideLengthLabel";
            SideLengthLabel.Size = new Size(141, 32);
            SideLengthLabel.TabIndex = 5;
            SideLengthLabel.Text = "Side Length";
            SideLengthLabel.Click += this.SideLengthLabel_Click;
            // 
            // DiagonalsLabel
            // 
            DiagonalsLabel.AutoSize = true;
            DiagonalsLabel.Font = new Font("Segoe UI", 12F);
            DiagonalsLabel.Location = new Point(186, 399);
            DiagonalsLabel.Name = "DiagonalsLabel";
            DiagonalsLabel.Size = new Size(119, 32);
            DiagonalsLabel.TabIndex = 6;
            DiagonalsLabel.Text = "Diagonals";
            DiagonalsLabel.Click += this.DiagonalsLabel_Click;
            // 
            // PerimiterLabel
            // 
            PerimiterLabel.AutoSize = true;
            PerimiterLabel.Font = new Font("Segoe UI", 12F);
            PerimiterLabel.Location = new Point(361, 205);
            PerimiterLabel.Name = "PerimiterLabel";
            PerimiterLabel.Size = new Size(109, 32);
            PerimiterLabel.TabIndex = 7;
            PerimiterLabel.Text = "Perimiter";
            PerimiterLabel.Click += this.PerimiterLabel_Click;
            // 
            // AreaLabel
            // 
            AreaLabel.AutoSize = true;
            AreaLabel.Font = new Font("Segoe UI", 12F);
            AreaLabel.Location = new Point(361, 301);
            AreaLabel.Name = "AreaLabel";
            AreaLabel.Size = new Size(62, 32);
            AreaLabel.TabIndex = 8;
            AreaLabel.Text = "Area";
            AreaLabel.Click += this.AreaLabel_Click;
            // 
            // TriangleAreaLabel
            // 
            TriangleAreaLabel.AutoSize = true;
            TriangleAreaLabel.Font = new Font("Segoe UI", 12F);
            TriangleAreaLabel.Location = new Point(361, 399);
            TriangleAreaLabel.Name = "TriangleAreaLabel";
            TriangleAreaLabel.Size = new Size(110, 32);
            TriangleAreaLabel.TabIndex = 9;
            TriangleAreaLabel.Text = "Segment";
            TriangleAreaLabel.Click += this.TriangleAreaLabel_Click;
            // 
            // InternalAngleLabel
            // 
            InternalAngleLabel.AutoSize = true;
            InternalAngleLabel.Font = new Font("Segoe UI", 12F);
            InternalAngleLabel.Location = new Point(538, 205);
            InternalAngleLabel.Name = "InternalAngleLabel";
            InternalAngleLabel.Size = new Size(164, 32);
            InternalAngleLabel.TabIndex = 10;
            InternalAngleLabel.Text = "Internal Angle";
            // 
            // ExternalAngleLabel
            // 
            ExternalAngleLabel.AutoSize = true;
            ExternalAngleLabel.Font = new Font("Segoe UI", 12F);
            ExternalAngleLabel.Location = new Point(538, 301);
            ExternalAngleLabel.Name = "ExternalAngleLabel";
            ExternalAngleLabel.Size = new Size(167, 32);
            ExternalAngleLabel.TabIndex = 11;
            ExternalAngleLabel.Text = "External Angle";
            ExternalAngleLabel.Click += this.ExternalAngleLabel_Click;
            // 
            // InteriorAngleSumLabel
            // 
            InteriorAngleSumLabel.AutoSize = true;
            InteriorAngleSumLabel.Font = new Font("Segoe UI", 12F);
            InteriorAngleSumLabel.Location = new Point(538, 399);
            InteriorAngleSumLabel.Name = "InteriorAngleSumLabel";
            InteriorAngleSumLabel.Size = new Size(146, 32);
            InteriorAngleSumLabel.TabIndex = 12;
            InteriorAngleSumLabel.Text = "Interior Sum";
            InteriorAngleSumLabel.Click += this.InteriorAngleSumLabel_Click;
            // 
            // ExteriorAngleSumLabel
            // 
            ExteriorAngleSumLabel.AutoSize = true;
            ExteriorAngleSumLabel.Font = new Font("Segoe UI", 12F);
            ExteriorAngleSumLabel.Location = new Point(538, 505);
            ExteriorAngleSumLabel.Name = "ExteriorAngleSumLabel";
            ExteriorAngleSumLabel.Size = new Size(149, 32);
            ExteriorAngleSumLabel.TabIndex = 13;
            ExteriorAngleSumLabel.Text = "Exterior Sum";
            // 
            // CoordinatesLabel
            // 
            CoordinatesLabel.AutoSize = true;
            CoordinatesLabel.Font = new Font("Segoe UI", 14F);
            CoordinatesLabel.Location = new Point(12, 499);
            CoordinatesLabel.Name = "CoordinatesLabel";
            CoordinatesLabel.Size = new Size(165, 38);
            CoordinatesLabel.TabIndex = 14;
            CoordinatesLabel.Text = "Coordinates";
            CoordinatesLabel.Click += this.CoordinatesLabel_Click;
            // 
            // PolygonLabel
            // 
            PolygonLabel.AutoSize = true;
            PolygonLabel.Font = new Font("Segoe UI", 18F);
            PolygonLabel.Location = new Point(12, 9);
            PolygonLabel.Name = "PolygonLabel";
            PolygonLabel.Size = new Size(220, 48);
            PolygonLabel.TabIndex = 15;
            PolygonLabel.Text = "Polygon Info";
            PolygonLabel.Click += this.PolygonLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(12, 240);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 45);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(12, 336);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 45);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(12, 434);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 45);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F);
            textBox4.Location = new Point(186, 240);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 45);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(186, 336);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(150, 45);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14F);
            textBox6.Location = new Point(186, 434);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(150, 45);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14F);
            textBox7.Location = new Point(361, 240);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(150, 45);
            textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 14F);
            textBox8.Location = new Point(361, 336);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(150, 45);
            textBox8.TabIndex = 23;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14F);
            textBox9.Location = new Point(361, 434);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(150, 45);
            textBox9.TabIndex = 24;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 14F);
            textBox10.Location = new Point(538, 240);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(150, 45);
            textBox10.TabIndex = 25;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 14F);
            textBox11.Location = new Point(538, 336);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(150, 45);
            textBox11.TabIndex = 26;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 14F);
            textBox12.Location = new Point(538, 434);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(150, 45);
            textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 14F);
            textBox13.Location = new Point(538, 540);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(150, 45);
            textBox13.TabIndex = 28;
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI", 14F);
            textBox14.Location = new Point(12, 540);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.RightToLeft = RightToLeft.Yes;
            textBox14.ScrollBars = ScrollBars.Vertical;
            textBox14.Size = new Size(499, 125);
            textBox14.TabIndex = 29;
            textBox14.TextChanged += this.textBox14_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(611, 32);
            label1.TabIndex = 30;
            label1.Text = "The details of the Plygon you have requested are below";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.Location = new Point(12, 108);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(78, 32);
            NameLabel.TabIndex = 31;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 14F);
            NameTextBox.Location = new Point(12, 143);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(324, 45);
            NameTextBox.TabIndex = 32;
            // 
            // RegenerateButton
            // 
            RegenerateButton.Font = new Font("Segoe UI", 12F);
            RegenerateButton.Location = new Point(361, 143);
            RegenerateButton.Name = "RegenerateButton";
            RegenerateButton.Size = new Size(166, 45);
            RegenerateButton.TabIndex = 33;
            RegenerateButton.Text = "Regenerate";
            RegenerateButton.UseVisualStyleBackColor = true;
            // 
            // PlotCoordsButton
            // 
            PlotCoordsButton.Font = new Font("Segoe UI", 12F);
            PlotCoordsButton.Location = new Point(539, 143);
            PlotCoordsButton.Name = "PlotCoordsButton";
            PlotCoordsButton.Size = new Size(166, 45);
            PlotCoordsButton.TabIndex = 34;
            PlotCoordsButton.Text = "Plot Coords";
            PlotCoordsButton.UseVisualStyleBackColor = true;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 694);
            Controls.Add(PlotCoordsButton);
            Controls.Add(RegenerateButton);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(label1);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PolygonLabel);
            Controls.Add(CoordinatesLabel);
            Controls.Add(ExteriorAngleSumLabel);
            Controls.Add(InteriorAngleSumLabel);
            Controls.Add(ExternalAngleLabel);
            Controls.Add(InternalAngleLabel);
            Controls.Add(TriangleAreaLabel);
            Controls.Add(AreaLabel);
            Controls.Add(PerimiterLabel);
            Controls.Add(DiagonalsLabel);
            Controls.Add(SideLengthLabel);
            Controls.Add(SidesLabel);
            Controls.Add(ApothemLabel);
            Controls.Add(RadiusLabel);
            Controls.Add(DiamaterLabel);
            Name = "DisplayForm";
            Text = "Polygon Drawer ";
            Load += this.DisplayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DiamaterLabel;
        private Label RadiusLabel;
        private Label ApothemLabel;
        private Label SidesLabel;
        private Label SideLengthLabel;
        private Label DiagonalsLabel;
        private Label PerimiterLabel;
        private Label AreaLabel;
        private Label TriangleAreaLabel;
        private Label InternalAngleLabel;
        private Label ExternalAngleLabel;
        private Label InteriorAngleSumLabel;
        private Label ExteriorAngleSumLabel;
        private Label CoordinatesLabel;
        private Label PolygonLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label1;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button RegenerateButton;
        private Button PlotCoordsButton;
    }
}