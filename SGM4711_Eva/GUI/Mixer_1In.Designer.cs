namespace SGM4711_Eva.GUI
{
    partial class Mixer_1In
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
            this.numUP_Input = new System.Windows.Forms.NumericUpDown();
            this.line1 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line2 = new SGM4711_Eva.MDUserCtrls.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.line3 = new SGM4711_Eva.MDUserCtrls.Line();
            this.multiply3 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // numUP_Input
            // 
            this.numUP_Input.DecimalPlaces = 3;
            this.numUP_Input.Location = new System.Drawing.Point(98, 30);
            this.numUP_Input.Maximum = new decimal(new int[] {
            255999,
            0,
            0,
            196608});
            this.numUP_Input.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            -2147483648});
            this.numUP_Input.Name = "numUP_Input";
            this.numUP_Input.Size = new System.Drawing.Size(59, 21);
            this.numUP_Input.TabIndex = 116;
            this.numUP_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_Input.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUP_Input.ValueChanged += new System.EventHandler(this.numUP_Input_ValueChanged);
            // 
            // line1
            // 
            this.line1.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Horizontal = false;
            this.line1.LeftOrUpArrow = false;
            this.line1.LineColor = System.Drawing.Color.SteelBlue;
            this.line1.LineWidth = 1;
            this.line1.Location = new System.Drawing.Point(122, 54);
            this.line1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line1.Name = "line1";
            this.line1.RightOrBelowArrow = true;
            this.line1.Size = new System.Drawing.Size(10, 25);
            this.line1.TabIndex = 115;
            // 
            // line2
            // 
            this.line2.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Horizontal = true;
            this.line2.LeftOrUpArrow = false;
            this.line2.LineColor = System.Drawing.Color.SteelBlue;
            this.line2.LineWidth = 1;
            this.line2.Location = new System.Drawing.Point(137, 84);
            this.line2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line2.Name = "line2";
            this.line2.RightOrBelowArrow = true;
            this.line2.Size = new System.Drawing.Size(66, 10);
            this.line2.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 113;
            this.label1.Text = "Input";
            // 
            // line3
            // 
            this.line3.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line3.BackColor = System.Drawing.Color.Transparent;
            this.line3.Horizontal = true;
            this.line3.LeftOrUpArrow = false;
            this.line3.LineColor = System.Drawing.Color.SteelBlue;
            this.line3.LineWidth = 1;
            this.line3.Location = new System.Drawing.Point(52, 84);
            this.line3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line3.Name = "line3";
            this.line3.RightOrBelowArrow = true;
            this.line3.Size = new System.Drawing.Size(66, 10);
            this.line3.TabIndex = 112;
            // 
            // multiply3
            // 
            this.multiply3.BackColor = System.Drawing.Color.Transparent;
            this.multiply3.DrawColor = System.Drawing.Color.SteelBlue;
            this.multiply3.Location = new System.Drawing.Point(117, 79);
            this.multiply3.MaximumSize = new System.Drawing.Size(100, 100);
            this.multiply3.MinimumSize = new System.Drawing.Size(10, 10);
            this.multiply3.Name = "multiply3";
            this.multiply3.Size = new System.Drawing.Size(20, 20);
            this.multiply3.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(209, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 14);
            this.label10.TabIndex = 107;
            this.label10.Text = "Output";
            // 
            // Mixer_1In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.numUP_Input);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.multiply3);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.Name = "Mixer_1In";
            this.Text = "Mixer_1In";
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUP_Input;
        private MDUserCtrls.Line line1;
        private MDUserCtrls.Line line2;
        private System.Windows.Forms.Label label1;
        private MDUserCtrls.Line line3;
        private MDUserCtrls.Multiply multiply3;
        private System.Windows.Forms.Label label10;
    }
}