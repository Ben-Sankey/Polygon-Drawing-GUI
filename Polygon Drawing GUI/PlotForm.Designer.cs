namespace Polygon_Drawing_GUI
{
    partial class PlotForm
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
            RegenerateButton = new Button();
            DetailsButton = new Button();
            PlotBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PlotBox).BeginInit();
            SuspendLayout();
            // 
            // RegenerateButton
            // 
            RegenerateButton.Location = new Point(40, 618);
            RegenerateButton.Name = "RegenerateButton";
            RegenerateButton.Size = new Size(140, 50);
            RegenerateButton.TabIndex = 0;
            RegenerateButton.Text = "Regenerate";
            RegenerateButton.UseVisualStyleBackColor = true;
            RegenerateButton.Click += RegenerateButton_Click;
            // 
            // DetailsButton
            // 
            DetailsButton.Location = new Point(186, 618);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(140, 50);
            DetailsButton.TabIndex = 1;
            DetailsButton.Text = "Details";
            DetailsButton.UseVisualStyleBackColor = true;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // PlotBox
            // 
            PlotBox.Location = new Point(40, 12);
            PlotBox.Name = "PlotBox";
            PlotBox.Size = new Size(600, 600);
            PlotBox.TabIndex = 2;
            PlotBox.TabStop = false;
            PlotBox.Paint += PlotBox_Draw;
            // 
            // PlotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 694);
            Controls.Add(PlotBox);
            Controls.Add(DetailsButton);
            Controls.Add(RegenerateButton);
            Name = "PlotForm";
            Text = "PlotForm";
            ((System.ComponentModel.ISupportInitialize)PlotBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button RegenerateButton;
        private Button DetailsButton;
        private PictureBox PlotBox;
    }
}