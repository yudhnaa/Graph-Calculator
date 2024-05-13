using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
namespace Graph_Calculator
{
    class Grid
    {
        Graphics graphic;
        int height;
        int width;
        PointF rootPoint;
        float cellSize;
        float magnification;

        public Grid(Panel panel)
        {
            graphic = panel.CreateGraphics();
            graphic.SmoothingMode = SmoothingMode.HighSpeed;
            width = panel.Width;
            height = panel.Height;
            magnification = 5;
            cellSize = 10 * magnification;
            rootPoint = new Point(width/2,height/2);
        }
        public void drawGrid()
        {
            Pen penXY = new Pen(Brushes.Black, 1);
            // Điều chỉnh đầu bút thành mũi tên đặc
            AdjustableArrowCap arrowCap = new AdjustableArrowCap(5, 5, true);
            penXY.CustomEndCap = arrowCap;
            Pen penGrid = new Pen(Color.FromArgb(50, 0, 0, 0), 1);

            // Hiệu chỉnh kích cỡ ô theo độ thu phóng
            this.cellSize = 10 * magnification;

            // Vẽ các trục oxy và ký hiệu oxy
            graphic.DrawLine(penXY, new PointF(width / 2, height), new PointF(width / 2, 0));
            graphic.DrawLine(penXY, new PointF(0, height / 2), new PointF(width, height / 2));
            graphic.DrawString("O", new Font("Tahoma", 14), Brushes.Black, new PointF(width / 2 + 2, height / 2 + 2));
            graphic.DrawString("x", new Font("Tahoma", 14), Brushes.Black, new PointF(width - 12, height / 2));
            graphic.DrawString("y", new Font("Tahoma", 14), Brushes.Black, new PointF(width / 2 + 5, 0));

            // Vẽ đường lưới
            for (int i = 1; i < (width / cellSize) / 2; i++)
            {
                // Vẽ đối xứng các đường lưới
                graphic.DrawLine(penGrid, new PointF(width / 2 + i * cellSize, 0), new PointF(width / 2 + i * cellSize, height));
                graphic.DrawLine(penGrid, new PointF(width / 2 + -i * cellSize, 0), new PointF(width / 2 + -i * cellSize, height));

                graphic.DrawLine(penGrid, new PointF(0, height / 2 + i * cellSize), new PointF(width, height / 2 + i * cellSize));
                graphic.DrawLine(penGrid, new PointF(0, height / 2 + -i * cellSize), new PointF(width, height / 2 + -i * cellSize));

                //Nếu độ lớn của cột đủ rộng thì vẽ thêm các giá trị trục x,y
                if (magnification >= 3)
                {
                    graphic.DrawString((i * 10).ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(width / 2 + i * cellSize, height / 2));
                    graphic.DrawString((-i * 10).ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(width / 2 + -i * cellSize, height / 2));

                    graphic.DrawString((i * 10).ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(width / 2 - 15, height / 2 + -i * cellSize));
                    graphic.DrawString((-i * 10).ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(width / 2 - 20, height / 2 + i * cellSize));
                }

            }

        }
        public void showGraph(Bitmap bmp)
        {
            graphic.DrawImage(bmp,0,0);
        }
        public void clearGrid()
        {
            graphic.Clear(Color.White);
            this.drawGrid();
        }

        public Graphics Graphic
        {
            get
            {
                return graphic;
            }

            set
            {
                graphic = value;
            }
        }

        public PointF RootPoint
        {
            get
            {
                return rootPoint;
            }

            set
            {
                rootPoint = value;
            }
        }

        public float CellSize
        {
            get
            {
                return cellSize;
            }

            set
            {
                cellSize = value;
            }
        }

        public float Magnification
        {
            get
            {
                return magnification;
            }

            set
            {
                magnification = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }
    }
}
