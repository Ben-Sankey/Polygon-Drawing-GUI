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
using static Polygon;
using static System.Windows.Forms.DataFormats;

namespace Polygon_Drawing_GUI
{
    public partial class DisplayForm : Form
    {
        private readonly InputForm InputForm;

        private readonly Polygon StoredPolygon;
        public DisplayForm(InputForm InputPrevious, double InputRadius, int InSides)
        {
            InitializeComponent();

            InputForm = InputPrevious;

            this.Location = InputForm.Location;

            StoredPolygon = new Polygon(InputRadius, InSides);

            NameTextBox.Text = "Ngon Placeholder";

            RadiusOut.Text = Math.Round((double)StoredPolygon.Radius, 3).ToString();
            DiamaterOut.Text = Math.Round((double)StoredPolygon.Diameter, 3).ToString();
            ApothemOut.Text = Math.Round((double)StoredPolygon.Apothem, 3).ToString();

            SidesOut.Text = Math.Round((double)StoredPolygon.Sides, 3).ToString();
            SideLengthOut.Text = Math.Round((double)StoredPolygon.SideLength, 3).ToString();
            DiagonalsOut.Text = StoredPolygon.Diagonals.ToString();

            AreaOut.Text = Math.Round((double)StoredPolygon.Area, 3).ToString();
            PerimiterOut.Text = Math.Round((double)StoredPolygon.Perimiter, 3).ToString();
            SegmentOut.Text = Math.Round((double)StoredPolygon.TriangleAreas, 3).ToString();

            InAngleOut.Text = StoredPolygon.InternalAngle.ToString();
            ExAngleOut.Text = StoredPolygon.ExternalAngle.ToString();
            InteriorSumOut.Text = StoredPolygon.InteriorAngleSum.ToString();
            ExteriorSumOut.Text = StoredPolygon.ExteriorAngleSum.ToString();

            CoordinatesOut.Text = CoordinatesToString(StoredPolygon.VertexCoordinates);

        }

        public void OnLoad(object sender, EventArgs e)
        {
            NameTextBox.Text = "Ngon Placeholder";

            RadiusOut.Text = Math.Round((double)StoredPolygon.Radius, 3).ToString();
            DiamaterOut.Text = Math.Round((double)StoredPolygon.Diameter, 3).ToString();
            ApothemOut.Text = Math.Round((double)StoredPolygon.Apothem, 3).ToString();

            SidesOut.Text = Math.Round((double)StoredPolygon.Sides, 3).ToString();
            SideLengthOut.Text = Math.Round((double)StoredPolygon.SideLength, 3).ToString();
            DiagonalsOut.Text = StoredPolygon.Diagonals.ToString();

            AreaOut.Text = Math.Round((double)StoredPolygon.Area, 3).ToString();
            PerimiterOut.Text = Math.Round((double)StoredPolygon.Perimiter, 3).ToString();
            SegmentOut.Text = Math.Round((double)StoredPolygon.TriangleAreas, 3).ToString();

            InAngleOut.Text = StoredPolygon.InternalAngle.ToString();
            ExAngleOut.Text = StoredPolygon.ExternalAngle.ToString();
            InteriorSumOut.Text = StoredPolygon.InteriorAngleSum.ToString();
            ExteriorSumOut.Text = StoredPolygon.ExteriorAngleSum.ToString();

            CoordinatesOut.Text = "lets see what is going on here";
        }

        private void RegenerateButton_Click(object sender, EventArgs e)
        {
            Hide();
            InputForm.Show();
        }

        private void PlotCoordsButton_Click(object sender, EventArgs e)
        {
            Form PlotForm = new PlotForm(InputForm, this, this.StoredPolygon);
            PlotForm.Show();
            Hide();
        }
    }
}
