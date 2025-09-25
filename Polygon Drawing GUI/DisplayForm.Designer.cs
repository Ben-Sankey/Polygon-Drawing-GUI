using static Polygon;

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
            RadiusOut = new TextBox();
            DiamaterOut = new TextBox();
            ApothemOut = new TextBox();
            SidesOut = new TextBox();
            SideLengthOut = new TextBox();
            DiagonalsOut = new TextBox();
            AreaOut = new TextBox();
            PerimiterOut = new TextBox();
            SegmentOut = new TextBox();
            InAngleOut = new TextBox();
            ExAngleOut = new TextBox();
            InteriorSumOut = new TextBox();
            ExteriorSumOut = new TextBox();
            CoordinatesOut = new TextBox();
            DescriptionLabel = new Label();
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
            DiamaterLabel.Location = new Point(12, 301);
            DiamaterLabel.Name = "DiamaterLabel";
            DiamaterLabel.Size = new Size(112, 32);
            DiamaterLabel.TabIndex = 1;
            DiamaterLabel.Text = "Diameter";
            // 
            // RadiusLabel
            // 
            RadiusLabel.AutoSize = true;
            RadiusLabel.Font = new Font("Segoe UI", 12F);
            RadiusLabel.Location = new Point(12, 205);
            RadiusLabel.Name = "RadiusLabel";
            RadiusLabel.Size = new Size(84, 32);
            RadiusLabel.TabIndex = 2;
            RadiusLabel.Text = "Radius";
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
            // 
            // PerimiterLabel
            // 
            PerimiterLabel.AutoSize = true;
            PerimiterLabel.Font = new Font("Segoe UI", 12F);
            PerimiterLabel.Location = new Point(361, 301);
            PerimiterLabel.Name = "PerimiterLabel";
            PerimiterLabel.Size = new Size(109, 32);
            PerimiterLabel.TabIndex = 7;
            PerimiterLabel.Text = "Perimiter";
            // 
            // AreaLabel
            // 
            AreaLabel.AutoSize = true;
            AreaLabel.Font = new Font("Segoe UI", 12F);
            AreaLabel.Location = new Point(361, 205);
            AreaLabel.Name = "AreaLabel";
            AreaLabel.Size = new Size(62, 32);
            AreaLabel.TabIndex = 8;
            AreaLabel.Text = "Area";
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
            // 
            // RadiusOut
            // 
            RadiusOut.Font = new Font("Segoe UI", 14F);
            RadiusOut.Location = new Point(12, 240);
            RadiusOut.Name = "RadiusOut";
            RadiusOut.ReadOnly = true;
            RadiusOut.Size = new Size(150, 45);
            RadiusOut.TabIndex = 16;
            RadiusOut.Text = "Radius Out";
            // 
            // DiamaterOut
            // 
            DiamaterOut.Font = new Font("Segoe UI", 14F);
            DiamaterOut.Location = new Point(12, 336);
            DiamaterOut.Name = "DiamaterOut";
            DiamaterOut.ReadOnly = true;
            DiamaterOut.Size = new Size(150, 45);
            DiamaterOut.TabIndex = 17;
            DiamaterOut.Text = "Diameter Out";
            // 
            // ApothemOut
            // 
            ApothemOut.Font = new Font("Segoe UI", 14F);
            ApothemOut.Location = new Point(12, 434);
            ApothemOut.Name = "ApothemOut";
            ApothemOut.ReadOnly = true;
            ApothemOut.Size = new Size(150, 45);
            ApothemOut.TabIndex = 18;
            ApothemOut.Text = "Apothem Out";
            // 
            // SidesOut
            // 
            SidesOut.Font = new Font("Segoe UI", 14F);
            SidesOut.Location = new Point(186, 240);
            SidesOut.Name = "SidesOut";
            SidesOut.ReadOnly = true;
            SidesOut.Size = new Size(150, 45);
            SidesOut.TabIndex = 19;
            SidesOut.Text = "Sides Out";
            // 
            // SideLengthOut
            // 
            SideLengthOut.Font = new Font("Segoe UI", 14F);
            SideLengthOut.Location = new Point(186, 336);
            SideLengthOut.Name = "SideLengthOut";
            SideLengthOut.ReadOnly = true;
            SideLengthOut.Size = new Size(150, 45);
            SideLengthOut.TabIndex = 20;
            SideLengthOut.Text = "Side Length Out";
            // 
            // DiagonalsOut
            // 
            DiagonalsOut.Font = new Font("Segoe UI", 14F);
            DiagonalsOut.Location = new Point(186, 434);
            DiagonalsOut.Name = "DiagonalsOut";
            DiagonalsOut.ReadOnly = true;
            DiagonalsOut.Size = new Size(150, 45);
            DiagonalsOut.TabIndex = 21;
            DiagonalsOut.Text = "Diagonals Out";
            // 
            // AreaOut
            // 
            AreaOut.Font = new Font("Segoe UI", 14F);
            AreaOut.Location = new Point(361, 240);
            AreaOut.Name = "AreaOut";
            AreaOut.ReadOnly = true;
            AreaOut.Size = new Size(150, 45);
            AreaOut.TabIndex = 22;
            AreaOut.Text = "Area Out";
            // 
            // PerimiterOut
            // 
            PerimiterOut.Font = new Font("Segoe UI", 14F);
            PerimiterOut.Location = new Point(361, 336);
            PerimiterOut.Name = "PerimiterOut";
            PerimiterOut.ReadOnly = true;
            PerimiterOut.Size = new Size(150, 45);
            PerimiterOut.TabIndex = 23;
            PerimiterOut.Text = "Perimiter Out";
            // 
            // SegmentOut
            // 
            SegmentOut.Font = new Font("Segoe UI", 14F);
            SegmentOut.Location = new Point(361, 434);
            SegmentOut.Name = "SegmentOut";
            SegmentOut.ReadOnly = true;
            SegmentOut.Size = new Size(150, 45);
            SegmentOut.TabIndex = 24;
            SegmentOut.Text = "Segment Out";
            // 
            // InAngleOut
            // 
            InAngleOut.Font = new Font("Segoe UI", 14F);
            InAngleOut.Location = new Point(538, 240);
            InAngleOut.Name = "InAngleOut";
            InAngleOut.ReadOnly = true;
            InAngleOut.Size = new Size(150, 45);
            InAngleOut.TabIndex = 25;
            InAngleOut.Text = "InAngle Out";
            // 
            // ExAngleOut
            // 
            ExAngleOut.Font = new Font("Segoe UI", 14F);
            ExAngleOut.Location = new Point(538, 336);
            ExAngleOut.Name = "ExAngleOut";
            ExAngleOut.ReadOnly = true;
            ExAngleOut.Size = new Size(150, 45);
            ExAngleOut.TabIndex = 26;
            ExAngleOut.Text = "ExAngle Out";
            // 
            // InteriorSumOut
            // 
            InteriorSumOut.Font = new Font("Segoe UI", 14F);
            InteriorSumOut.Location = new Point(538, 434);
            InteriorSumOut.Name = "InteriorSumOut";
            InteriorSumOut.ReadOnly = true;
            InteriorSumOut.Size = new Size(150, 45);
            InteriorSumOut.TabIndex = 27;
            InteriorSumOut.Text = "Interior Sum";
            // 
            // ExteriorSumOut
            // 
            ExteriorSumOut.Font = new Font("Segoe UI", 14F);
            ExteriorSumOut.Location = new Point(538, 540);
            ExteriorSumOut.Name = "ExteriorSumOut";
            ExteriorSumOut.ReadOnly = true;
            ExteriorSumOut.Size = new Size(150, 45);
            ExteriorSumOut.TabIndex = 28;
            ExteriorSumOut.Text = "Exterior Sum";
            // 
            // CoordinatesOut
            // 
            CoordinatesOut.Font = new Font("Segoe UI", 14F);
            CoordinatesOut.Location = new Point(12, 540);
            CoordinatesOut.MaxLength = 10000;
            CoordinatesOut.Name = "CoordinatesOut";
            CoordinatesOut.ReadOnly = true;
            CoordinatesOut.RightToLeft = RightToLeft.Yes;
            CoordinatesOut.ScrollBars = ScrollBars.Vertical;
            CoordinatesOut.ShortcutsEnabled = false;
            CoordinatesOut.Size = new Size(499, 45);
            CoordinatesOut.TabIndex = 3;
            CoordinatesOut.Text = "Coordinates Out";
            CoordinatesOut.TextAlign = HorizontalAlignment.Right;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 12F);
            DescriptionLabel.Location = new Point(12, 63);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(611, 32);
            DescriptionLabel.TabIndex = 30;
            DescriptionLabel.Text = "The details of the Plygon you have requested are below";
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
            RegenerateButton.Click += RegenerateButton_Click;
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
            PlotCoordsButton.Click += PlotCoordsButton_Click;
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
            Controls.Add(DescriptionLabel);
            Controls.Add(CoordinatesOut);
            Controls.Add(ExteriorSumOut);
            Controls.Add(InteriorSumOut);
            Controls.Add(ExAngleOut);
            Controls.Add(InAngleOut);
            Controls.Add(SegmentOut);
            Controls.Add(PerimiterOut);
            Controls.Add(AreaOut);
            Controls.Add(DiagonalsOut);
            Controls.Add(SideLengthOut);
            Controls.Add(SidesOut);
            Controls.Add(ApothemOut);
            Controls.Add(DiamaterOut);
            Controls.Add(RadiusOut);
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
            Load += DisplayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
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
        private TextBox RadiusOut;
        private TextBox DiamaterOut;
        private TextBox ApothemOut;
        private TextBox SidesOut;
        private TextBox SideLengthOut;
        private TextBox DiagonalsOut;
        private TextBox AreaOut;
        private TextBox PerimiterOut;
        private TextBox SegmentOut;
        private TextBox InAngleOut;
        private TextBox ExAngleOut;
        private TextBox InteriorSumOut;
        private TextBox ExteriorSumOut;
        private TextBox CoordinatesOut;
        private Label DescriptionLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button RegenerateButton;
        private Button PlotCoordsButton;
    }
}