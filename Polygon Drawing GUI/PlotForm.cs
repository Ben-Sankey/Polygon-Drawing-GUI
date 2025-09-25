using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Coordinates;

namespace Polygon_Drawing_GUI
{
    public partial class PlotForm : Form
    {
        private readonly InputForm FirstForm;

        private readonly DisplayForm SecondForm;

        private Point[] PlotPoints;

        Polygon StoredPolygon;
        public PlotForm(InputForm InputForm, DisplayForm DetailsForm, Polygon InputPolygon)
        {
            InitializeComponent();

            FirstForm = InputForm;

            SecondForm = DetailsForm;

            this.Location = SecondForm.Location;

            Pen drawPen = new Pen(Color.Cyan, 3);

            PlotPoints = CoordinatesToPoints(OffsetCoordinates(InputPolygon.VertexCoordinates, PlotBox.Size.Width/2, PlotBox.Size.Height/2));

            StoredPolygon = InputPolygon;



        }

        private void RegenerateButton_Click(object sender, EventArgs e)
        {
            FirstForm.Show();
            this.Hide();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            SecondForm.Show();
            this.Hide();
        }

        private void PlotBox_Draw(object sender, PaintEventArgs e)
        {
            PlotBox.BackColor = Color.White;


            Pen drawPen = new Pen(Color.Cyan, 3);

            e.Graphics.DrawPolygon(drawPen, PlotPoints);
        }

        private void PlotBox_Click(object sender, EventArgs e)
        {

        }
    }
}
