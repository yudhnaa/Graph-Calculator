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

            expString = Regex.Replace(expString, @"(?:sin|cos|tan)|(\d+)([a-zA-Z]+)", match =>
            {
                // Nếu match là một chuỗi "sin", "cos" hoặc "tan", thì chuyển thành viết hoa chữ đầu
                if (match.Value == "sin" || match.Value == "cos" || match.Value == "tan")
                {
                    return match.Value.Substring(0, 1).ToUpper() + match.Value.Substring(1, match.Value.Length - 1);
                }
                else
                {
                    // Nếu match là một số và một ký tự liền kề, thì thay thế thành số*ký tự
                    string temp = match.Groups[0].Value[0].ToString();
                    for (int i = 1; i < match.Groups[0].Value.Length; i++)
                    {
                        temp += "*" + match.Groups[0].Value[i];
                    }
                    return temp;
                }
            });
            expString = Regex.Replace(expString, @"cot\((.*?)\)", match =>
            {
                string x = match.Groups[1].Value; // Lấy giá trị của x trong chuỗi "cot(x)"
                return $"Cos({x})/Sin({x})";      // Thay thế "cot(x)" thành "Cos(x)/Sin(x)"
            });
            expString = Regex.Replace(expString, @"[a-zA-Z]+", match =>
             {
                 return "x";
             });

            return expString;
        }
        private void drawwww()
        {
            graph.clearPanel();
            string expString = normalizeExpString(tbFx.Text);
            tbFx.Text = expString;
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