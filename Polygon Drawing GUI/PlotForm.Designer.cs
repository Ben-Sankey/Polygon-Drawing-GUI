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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // RegenerateButton
            // 
            RegenerateButton.Location = new Point(31, 614);
            RegenerateButton.Name = "RegenerateButton";
            RegenerateButton.Size = new Size(140, 50);
            RegenerateButton.TabIndex = 0;
            RegenerateButton.Text = "Regenerate";
            RegenerateButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            DetailsButton.Location = new Point(177, 614);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(140, 50);
            DetailsButton.TabIndex = 1;
            DetailsButton.Text = "Details";
            DetailsButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 596);
            panel1.TabIndex = 2;
            // 
            // PlotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 694);
            Controls.Add(panel1);
            Controls.Add(DetailsButton);
            Controls.Add(RegenerateButton);
            Name = "PlotForm";
            Text = "PlotForm";
            ResumeLayout(false);
        }

        #endregion

        private Button RegenerateButton;
        private Button DetailsButton;
        private Panel panel1;
    }
}