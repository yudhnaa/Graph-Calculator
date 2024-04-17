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
using System.Text.RegularExpressions;


namespace Graph_Calculator
{
    public partial class formMain : Form
    {
        Grid grid;
        List<Graph> graphs;
        public formMain()
        {
            InitializeComponent();

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            grid = new Grid(panelGrid);
            graphs = new List<Graph>();
            trackBarZoom.SetRange(1, 20);
            trackBarZoom.Value = (int) grid.Magnification;

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            grid.drawGrid();
            
        }
        public void takeExp()
        {
            for (int i = 0; i < (tableLayouPaneltExp.RowCount * tableLayouPaneltExp.ColumnCount); i++)
            {
                string expString = tableLayouPaneltExp.Controls[i].Text;
                if (tableLayouPaneltExp.Controls[i] is TextBox && expString != "")
                {

                    Graph graph = new Graph(grid, expString);
                    graph.drawGraph();
                    graphs.Add(graph);
                }
            }
        }
        public void showGraph()
        {
            grid.clearGrid();
            foreach (Graph gr in graphs)
            {
                grid.showGraph(gr.OriginBmp);
            }

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            graphs.Clear();
            takeExp();
            showGraph();
        }

        private void btZoomOut_Click(object sender, EventArgs e)
        {
            if (grid.Magnification - 1 > 0)
            {
                grid.Magnification = grid.Magnification - 1;
                grid.clearGrid();
                foreach (Graph gr in graphs)
                {
                    gr.drawGraph();
                    grid.showGraph(gr.OriginBmp);
                }
                trackBarZoom.Value = (int) grid.Magnification;
            }
        }

        private void btZoomIn_Click(object sender, EventArgs e)
        {
            if (grid.Magnification + 1 <= 20)
            {
                grid.Magnification = grid.Magnification + 1;
                grid.clearGrid();
                foreach (Graph gr in graphs)
                {
                    gr.drawGraph();
                    grid.showGraph(gr.OriginBmp);
                }
                trackBarZoom.Value = (int)grid.Magnification;
            }
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            grid.Magnification = trackBarZoom.Value;
            grid.clearGrid();
            foreach (Graph gr in graphs)
            {
                gr.drawGraph();
                grid.showGraph(gr.OriginBmp);
            }
        }

        private void btAddExp_Click(object sender, EventArgs e)
        {
            Label lbFn = new Label();
            lbFn.Name = "lbF" + tableLayouPaneltExp.RowCount.ToString();
            lbFn.Anchor = AnchorStyles.Left;
            lbFn.Text = String.Format("f{0}(x) = ", (tableLayouPaneltExp.RowCount+1).ToString());

            TextBox tbFn = new TextBox();
            tbFn.Name = "tbF" + tableLayouPaneltExp.RowCount.ToString();
            tbFn.Anchor = AnchorStyles.Left;
            tbFn.Text = "";
            tbFn.WordWrap = false;
            tbFn.Width = tbF1.Width;

            tableLayouPaneltExp.Controls.Add(lbFn,0,tableLayouPaneltExp.RowCount);
            tableLayouPaneltExp.Controls.Add(tbFn, 1, tableLayouPaneltExp.RowCount++);


        }
    }
}