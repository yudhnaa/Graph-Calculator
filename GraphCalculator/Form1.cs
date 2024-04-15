using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace GraphCalculator
{
    public partial class formMain : Form
    {
        Graph graph;
        public formMain()
        {
            InitializeComponent();

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            graph = new Graph(panelGrid);
            trackBarZoom.SetRange(1, 20);
            trackBarZoom.Value = graph.Magnification;

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            graph.drawGrid();

        }
        private string normalizeExpString(string expString)
        {
            expString = expString.Replace("sin", "Sin");
            expString = expString.Replace("cos", "Cos");
            expString = expString.Replace("tan", "Tan");
            expString = expString.Replace("cot", "Cot");

            return expString;
        }
        private void drawwww()
        {
            graph.clearPanel();
            string expString = normalizeExpString(tbFx.Text);

            if (expString != "")
                graph.drawGraph(expString);

        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            drawwww();
        }

        private void btZoomOut_Click(object sender, EventArgs e)
        {
            graph.Magnification = graph.Magnification - 1 > 0 ? graph.Magnification - 1 : graph.Magnification;
            drawwww();
            trackBarZoom.Value = graph.Magnification;
        }

        private void btZoomIn_Click(object sender, EventArgs e)
        {
            graph.Magnification = graph.Magnification + 1 <= 20 ? graph.Magnification + 1 : graph.Magnification;
            drawwww();
            trackBarZoom.Value = graph.Magnification;
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            graph.Magnification = trackBarZoom.Value;
            drawwww();
        }
    }
}