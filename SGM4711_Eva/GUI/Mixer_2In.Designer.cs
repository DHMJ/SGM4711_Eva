namespace SGM4711_Eva.GUI
{
    partial class Mixer_2In
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
            this.numUP_Input1 = new System.Windows.Forms.NumericUpDown();
            this.numUP_Input0 = new System.Windows.Forms.NumericUpDown();
            this.line19 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line20 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line18 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line17 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line15 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line16 = new SGM4711_Eva.MDUserCtrls.Line();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.line13 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line14 = new SGM4711_Eva.MDUserCtrls.Line();
            this.multiply2 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.multiply1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.add1 = new SGM4711_Eva.MDUserCtrls.Add();
            this.label10 = new System.Windows.Forms.Label();
            this.line12 = new SGM4711_Eva.MDUserCtrls.Line();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Input0)).BeginInit();
            this.SuspendLayout();
            // 
            // numUP_Input1
            // 
            this.numUP_Input1.DecimalPlaces = 3;
            this.numUP_Input1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUP_Input1.Location = new System.Drawing.Point(71, 205);
            this.numUP_Input1.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            196608});
            this.numUP_Input1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numUP_Input1.Name = "numUP_Input1";
            this.numUP_Input1.Size = new System.Drawing.Size(59, 21);
            this.numUP_Input1.TabIndex = 81;
            this.numUP_Input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_Input1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUP_Input1.ValueChanged += new System.EventHandler(this.numUP_Input1_ValueChanged);
            // 
            // numUP_Input0
            // 
            this.numUP_Input0.DecimalPlaces = 3;
            this.numUP_Input0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUP_Input0.Location = new System.Drawing.Point(71, 21);
            this.numUP_Input0.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            196608});
            this.numUP_Input0.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numUP_Input0.Name = "numUP_Input0";
            this.numUP_Input0.Size = new System.Drawing.Size(59, 21);
            this.numUP_Input0.TabIndex = 82;
            this.numUP_Input0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_Input0.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUP_Input0.ValueChanged += new System.EventHandler(this.numUP_Input0_ValueChanged);
            // 
            // line19
            // 
            this.line19.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line19.BackColor = System.Drawing.Color.Transparent;
            this.line19.Horizontal = false;
            this.line19.LeftOrUpArrow = true;
            this.line19.LineColor = System.Drawing.Color.SteelBlue;
            this.line19.LineWidth = 1;
            this.line19.Location = new System.Drawing.Point(95, 177);
            this.line19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line19.Name = "line19";
            this.line19.RightOrBelowArrow = false;
            this.line19.Size = new System.Drawing.Size(10, 25);
            this.line19.TabIndex = 80;
            // 
            // line20
            // 
            this.line20.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line20.BackColor = System.Drawing.Color.Transparent;
            this.line20.Horizontal = false;
            this.line20.LeftOrUpArrow = false;
            this.line20.LineColor = System.Drawing.Color.SteelBlue;
            this.line20.LineWidth = 1;
            this.line20.Location = new System.Drawing.Point(95, 45);
            this.line20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line20.Name = "line20";
            this.line20.RightOrBelowArrow = true;
            this.line20.Size = new System.Drawing.Size(10, 25);
            this.line20.TabIndex = 79;
            // 
            // line18
            // 
            this.line18.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line18.BackColor = System.Drawing.Color.Transparent;
            this.line18.Horizontal = true;
            this.line18.LeftOrUpArrow = false;
            this.line18.LineColor = System.Drawing.Color.SteelBlue;
            this.line18.LineWidth = 1;
            this.line18.Location = new System.Drawing.Point(110, 161);
            this.line18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line18.Name = "line18";
            this.line18.RightOrBelowArrow = false;
            this.line18.Size = new System.Drawing.Size(66, 10);
            this.line18.TabIndex = 78;
            // 
            // line17
            // 
            this.line17.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line17.BackColor = System.Drawing.Color.Transparent;
            this.line17.Horizontal = false;
            this.line17.LeftOrUpArrow = true;
            this.line17.LineColor = System.Drawing.Color.SteelBlue;
            this.line17.LineWidth = 1;
            this.line17.Location = new System.Drawing.Point(171, 133);
            this.line17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line17.Name = "line17";
            this.line17.RightOrBelowArrow = false;
            this.line17.Size = new System.Drawing.Size(10, 34);
            this.line17.TabIndex = 77;
            // 
            // line15
            // 
            this.line15.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line15.BackColor = System.Drawing.Color.Transparent;
            this.line15.Horizontal = true;
            this.line15.LeftOrUpArrow = false;
            this.line15.LineColor = System.Drawing.Color.SteelBlue;
            this.line15.LineWidth = 1;
            this.line15.Location = new System.Drawing.Point(110, 75);
            this.line15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line15.Name = "line15";
            this.line15.RightOrBelowArrow = false;
            this.line15.Size = new System.Drawing.Size(66, 10);
            this.line15.TabIndex = 75;
            // 
            // line16
            // 
            this.line16.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line16.BackColor = System.Drawing.Color.Transparent;
            this.line16.Horizontal = false;
            this.line16.LeftOrUpArrow = false;
            this.line16.LineColor = System.Drawing.Color.SteelBlue;
            this.line16.LineWidth = 1;
            this.line16.Location = new System.Drawing.Point(171, 80);
            this.line16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line16.Name = "line16";
            this.line16.RightOrBelowArrow = true;
            this.line16.Size = new System.Drawing.Size(10, 34);
            this.line16.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(24, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 14);
            this.label12.TabIndex = 73;
            this.label12.Text = "Input 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(25, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 14);
            this.label13.TabIndex = 74;
            this.label13.Text = "Input 0";
            // 
            // line13
            // 
            this.line13.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line13.BackColor = System.Drawing.Color.Transparent;
            this.line13.Horizontal = true;
            this.line13.LeftOrUpArrow = false;
            this.line13.LineColor = System.Drawing.Color.SteelBlue;
            this.line13.LineWidth = 1;
            this.line13.Location = new System.Drawing.Point(25, 161);
            this.line13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.line13.Name = "line13";
            this.line13.RightOrBelowArrow = true;
            this.line13.Size = new System.Drawing.Size(66, 10);
            this.line13.TabIndex = 71;
            // 
            // line14
            // 
            this.line14.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line14.BackColor = System.Drawing.Color.Transparent;
            this.line14.Horizontal = true;
            this.line14.LeftOrUpArrow = false;
            this.line14.LineColor = System.Drawing.Color.SteelBlue;
            this.line14.LineWidth = 1;
            this.line14.Location = new System.Drawing.Point(25, 75);
            this.line14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line14.Name = "line14";
            this.line14.RightOrBelowArrow = true;
            this.line14.Size = new System.Drawing.Size(66, 10);
            this.line14.TabIndex = 72;
            // 
            // multiply2
            // 
            this.multiply2.BackColor = System.Drawing.Color.Transparent;
            this.multiply2.DrawColor = System.Drawing.Color.SteelBlue;
            this.multiply2.Location = new System.Drawing.Point(90, 156);
            this.multiply2.MaximumSize = new System.Drawing.Size(100, 100);
            this.multiply2.MinimumSize = new System.Drawing.Size(10, 10);
            this.multiply2.Name = "multiply2";
            this.multiply2.Size = new System.Drawing.Size(20, 20);
            this.multiply2.TabIndex = 69;
            // 
            // multiply1
            // 
            this.multiply1.BackColor = System.Drawing.Color.Transparent;
            this.multiply1.DrawColor = System.Drawing.Color.SteelBlue;
            this.multiply1.Location = new System.Drawing.Point(90, 70);
            this.multiply1.MaximumSize = new System.Drawing.Size(100, 100);
            this.multiply1.MinimumSize = new System.Drawing.Size(10, 10);
            this.multiply1.Name = "multiply1";
            this.multiply1.Size = new System.Drawing.Size(20, 20);
            this.multiply1.TabIndex = 70;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.Transparent;
            this.add1.DrawColor = System.Drawing.Color.SteelBlue;
            this.add1.Location = new System.Drawing.Point(166, 113);
            this.add1.MaximumSize = new System.Drawing.Size(100, 100);
            this.add1.MinimumSize = new System.Drawing.Size(10, 10);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(20, 20);
            this.add1.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(248, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 14);
            this.label10.TabIndex = 67;
            this.label10.Text = "Output";
            // 
            // line12
            // 
            this.line12.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line12.BackColor = System.Drawing.Color.Transparent;
            this.line12.Horizontal = true;
            this.line12.LeftOrUpArrow = false;
            this.line12.LineColor = System.Drawing.Color.SteelBlue;
            this.line12.LineWidth = 1;
            this.line12.Location = new System.Drawing.Point(186, 118);
            this.line12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line12.Name = "line12";
            this.line12.RightOrBelowArrow = true;
            this.line12.Size = new System.Drawing.Size(55, 10);
            this.line12.TabIndex = 66;
            // 
            // Mixer_2In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 260);
            this.Controls.Add(this.numUP_Input1);
            this.Controls.Add(this.numUP_Input0);
            this.Controls.Add(this.line19);
            this.Controls.Add(this.line20);
            this.Controls.Add(this.line18);
            this.Controls.Add(this.line17);
            this.Controls.Add(this.line15);
            this.Controls.Add(this.line16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.line13);
            this.Controls.Add(this.line14);
            this.Controls.Add(this.multiply2);
            this.Controls.Add(this.multiply1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.line12);
            this.MaximizeBox = false;
            this.Name = "Mixer_2In";
            this.Text = "2 Input Mixer";
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Input0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUP_Input1;
        private System.Windows.Forms.NumericUpDown numUP_Input0;
        private MDUserCtrls.Line line19;
        private MDUserCtrls.Line line20;
        private MDUserCtrls.Line line18;
        private MDUserCtrls.Line line17;
        private MDUserCtrls.Line line15;
        private MDUserCtrls.Line line16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MDUserCtrls.Line line13;
        private MDUserCtrls.Line line14;
        private MDUserCtrls.Multiply multiply2;
        private MDUserCtrls.Multiply multiply1;
        private MDUserCtrls.Add add1;
        private System.Windows.Forms.Label label10;
        private MDUserCtrls.Line line12;
    }
}