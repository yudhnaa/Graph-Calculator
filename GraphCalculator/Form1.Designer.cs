namespace GraphCalculator
{
    partial class formMain
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
            this.panelGrid = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.btZoomIn = new System.Windows.Forms.Button();
            this.btZoomOut = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFx = new System.Windows.Forms.TextBox();
            this.panelGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.hScrollBar1);
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(800, 520);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 503);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(797, 17);
            this.hScrollBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.trackBarZoom);
            this.panel1.Controls.Add(this.btZoomIn);
            this.panel1.Controls.Add(this.btZoomOut);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFx);
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 520);
            this.panel1.TabIndex = 0;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(37, 149);
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(202, 45);
            this.trackBarZoom.TabIndex = 4;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // btZoomIn
            // 
            this.btZoomIn.Location = new System.Drawing.Point(241, 155);
            this.btZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(31, 32);
            this.btZoomIn.TabIndex = 3;
            this.btZoomIn.Text = "+";
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.Click += new System.EventHandler(this.btZoomIn_Click);
            // 
            // btZoomOut
            // 
            this.btZoomOut.Location = new System.Drawing.Point(3, 155);
            this.btZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(31, 32);
            this.btZoomOut.TabIndex = 3;
            this.btZoomOut.Text = "-";
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.Click += new System.EventHandler(this.btZoomOut_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(86, 93);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(126, 35);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw Graph";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(x) = ";
            // 
            // tbFx
            // 
            this.tbFx.Location = new System.Drawing.Point(71, 29);
            this.tbFx.Name = "tbFx";
            this.tbFx.Size = new System.Drawing.Size(198, 29);
            this.tbFx.TabIndex = 0;
            this.tbFx.Text = "Sin(x)";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGrid);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFx;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btZoomOut;
        private System.Windows.Forms.Button btZoomIn;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

