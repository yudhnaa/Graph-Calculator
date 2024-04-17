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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.btZoomIn = new System.Windows.Forms.Button();
            this.btZoomOut = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tbGx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(800, 520);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trackBarZoom);
            this.panel1.Controls.Add(this.btZoomIn);
            this.panel1.Controls.Add(this.btZoomOut);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbGx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFx);
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 520);
            this.panel1.TabIndex = 0;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(33, 493);
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(391, 45);
            this.trackBarZoom.TabIndex = 4;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // btZoomIn
            // 
            this.btZoomIn.Location = new System.Drawing.Point(431, 491);
            this.btZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(26, 29);
            this.btZoomIn.TabIndex = 3;
            this.btZoomIn.Text = "+";
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.Click += new System.EventHandler(this.btZoomIn_Click);
            // 
            // btZoomOut
            // 
            this.btZoomOut.Location = new System.Drawing.Point(0, 491);
            this.btZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(26, 29);
            this.btZoomOut.TabIndex = 3;
            this.btZoomOut.Text = "-";
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.Click += new System.EventHandler(this.btZoomOut_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(174, 121);
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
            this.tbFx.Location = new System.Drawing.Point(84, 31);
            this.tbFx.Name = "tbFx";
            this.tbFx.Size = new System.Drawing.Size(333, 29);
            this.tbFx.TabIndex = 0;
            this.tbFx.Text = "Sin(x)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(198, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(282, 324);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(356, 324);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(37, 178);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(198, 227);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(113, 227);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(37, 227);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 32);
            this.button8.TabIndex = 8;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(361, 178);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 32);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(282, 178);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 32);
            this.button10.TabIndex = 10;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(198, 178);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 32);
            this.button11.TabIndex = 11;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(113, 178);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 32);
            this.button12.TabIndex = 12;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(361, 227);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(61, 32);
            this.button13.TabIndex = 9;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(282, 227);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 32);
            this.button14.TabIndex = 10;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(198, 275);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 32);
            this.button15.TabIndex = 6;
            this.button15.Text = "Tan()";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(113, 275);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(61, 32);
            this.button16.TabIndex = 7;
            this.button16.Text = "Cos()";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(37, 275);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(61, 32);
            this.button17.TabIndex = 8;
            this.button17.Text = "Sin()";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(282, 275);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(61, 32);
            this.button18.TabIndex = 10;
            this.button18.Text = "Cot()";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(361, 275);
            this.button19.Margin = new System.Windows.Forms.Padding(0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(61, 32);
            this.button19.TabIndex = 10;
            this.button19.Text = "AC";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(37, 324);
            this.button20.Margin = new System.Windows.Forms.Padding(0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(61, 32);
            this.button20.TabIndex = 8;
            this.button20.Text = "Pow()";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // tbGx
            // 
            this.tbGx.Location = new System.Drawing.Point(84, 69);
            this.tbGx.Name = "tbGx";
            this.tbGx.Size = new System.Drawing.Size(333, 29);
            this.tbGx.TabIndex = 0;
            this.tbGx.Text = "Cos(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "g(x) = ";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 520);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGx;
    }
}

