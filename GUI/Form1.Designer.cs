
namespace GUI
{
    partial class Form1
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
            lblA = new Label();
            txtWeightA = new TextBox();
            txtweightC = new TextBox();
            lblC = new Label();
            txtweightB = new TextBox();
            lblB = new Label();
            grprun = new GroupBox();
            txtHint = new TextBox();
            txtresult = new TextBox();
            numericUpDown1 = new NumericUpDown();
            Start = new Button();
            splitter1 = new Splitter();
            txtweightD = new TextBox();
            label1 = new Label();
            txtweightE = new TextBox();
            label2 = new Label();
            txtweightF = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtvolumeA = new TextBox();
            txtvolumeB = new TextBox();
            txtvolumeC = new TextBox();
            txtvolumeD = new TextBox();
            txtvolumeE = new TextBox();
            txtvolumeF = new TextBox();
            label5 = new Label();
            grprun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(88, 71);
            lblA.Name = "lblA";
            lblA.Size = new Size(54, 20);
            lblA.TabIndex = 0;
            lblA.Text = "Point 1";
            lblA.Click += lblA_Click;
            // 
            // txtWeightA
            // 
            txtWeightA.Location = new Point(172, 68);
            txtWeightA.Name = "txtWeightA";
            txtWeightA.Size = new Size(125, 27);
            txtWeightA.TabIndex = 1;
            txtWeightA.TextChanged += txtWeightA_TextChanged;
            // 
            // txtweightC
            // 
            txtweightC.Location = new Point(172, 134);
            txtweightC.Name = "txtweightC";
            txtweightC.Size = new Size(125, 27);
            txtweightC.TabIndex = 3;
            txtweightC.TextChanged += txtweightC_TextChanged;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(88, 134);
            lblC.Name = "lblC";
            lblC.Size = new Size(54, 20);
            lblC.TabIndex = 2;
            lblC.Text = "Point 3";
            // 
            // txtweightB
            // 
            txtweightB.Location = new Point(172, 101);
            txtweightB.Name = "txtweightB";
            txtweightB.Size = new Size(125, 27);
            txtweightB.TabIndex = 5;
            txtweightB.TextChanged += txtweightB_TextChanged;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(88, 104);
            lblB.Name = "lblB";
            lblB.Size = new Size(54, 20);
            lblB.TabIndex = 4;
            lblB.Text = "Point 2";
            lblB.Click += lblB_Click;
            // 
            // grprun
            // 
            grprun.Controls.Add(txtHint);
            grprun.Controls.Add(txtresult);
            grprun.Controls.Add(numericUpDown1);
            grprun.Controls.Add(Start);
            grprun.Location = new Point(88, 324);
            grprun.Name = "grprun";
            grprun.Size = new Size(414, 207);
            grprun.TabIndex = 6;
            grprun.TabStop = false;
            grprun.Text = "Run";
            // 
            // txtHint
            // 
            txtHint.Enabled = false;
            txtHint.Location = new Point(6, 61);
            txtHint.Multiline = true;
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(376, 25);
            txtHint.TabIndex = 9;
            txtHint.Text = "Weight threshold: 30, Volume threshold: 800";
            txtHint.Visible = false;
            // 
            // txtresult
            // 
            txtresult.Enabled = false;
            txtresult.Location = new Point(6, 116);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(376, 85);
            txtresult.TabIndex = 8;
            txtresult.Visible = false;
            txtresult.TextChanged += txtresult_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(115, 28);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Start
            // 
            Start.Location = new Point(6, 26);
            Start.Name = "Start";
            Start.Size = new Size(94, 29);
            Start.TabIndex = 7;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 645);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // txtweightD
            // 
            txtweightD.Location = new Point(172, 167);
            txtweightD.Name = "txtweightD";
            txtweightD.Size = new Size(125, 27);
            txtweightD.TabIndex = 10;
            txtweightD.TextChanged += txtweightD_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 170);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Point 4";
            label1.Click += label1_Click;
            // 
            // txtweightE
            // 
            txtweightE.Location = new Point(172, 200);
            txtweightE.Name = "txtweightE";
            txtweightE.Size = new Size(125, 27);
            txtweightE.TabIndex = 12;
            txtweightE.TextChanged += txtweightE_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 200);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 11;
            label2.Text = "Point 5";
            label2.Click += label2_Click;
            // 
            // txtweightF
            // 
            txtweightF.Location = new Point(172, 233);
            txtweightF.Name = "txtweightF";
            txtweightF.Size = new Size(125, 27);
            txtweightF.TabIndex = 14;
            txtweightF.TextChanged += txtweightF_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 233);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 13;
            label3.Text = "Point 6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 28);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 15;
            label4.Text = "Weight";
            label4.Click += label4_Click;
            // 
            // txtvolumeA
            // 
            txtvolumeA.Location = new Point(326, 68);
            txtvolumeA.Name = "txtvolumeA";
            txtvolumeA.Size = new Size(125, 27);
            txtvolumeA.TabIndex = 16;
            txtvolumeA.TextChanged += txtvolumeA_TextChanged;
            // 
            // txtvolumeB
            // 
            txtvolumeB.Location = new Point(326, 101);
            txtvolumeB.Name = "txtvolumeB";
            txtvolumeB.Size = new Size(125, 27);
            txtvolumeB.TabIndex = 17;
            txtvolumeB.TextChanged += txtvolumeB_TextChanged;
            // 
            // txtvolumeC
            // 
            txtvolumeC.Location = new Point(326, 134);
            txtvolumeC.Name = "txtvolumeC";
            txtvolumeC.Size = new Size(125, 27);
            txtvolumeC.TabIndex = 18;
            txtvolumeC.TextChanged += txtvolumeC_TextChanged;
            // 
            // txtvolumeD
            // 
            txtvolumeD.Location = new Point(326, 167);
            txtvolumeD.Name = "txtvolumeD";
            txtvolumeD.Size = new Size(125, 27);
            txtvolumeD.TabIndex = 19;
            txtvolumeD.TextChanged += txtvolumeD_TextChanged;
            // 
            // txtvolumeE
            // 
            txtvolumeE.Location = new Point(326, 200);
            txtvolumeE.Name = "txtvolumeE";
            txtvolumeE.Size = new Size(125, 27);
            txtvolumeE.TabIndex = 20;
            txtvolumeE.TextChanged += txtvolumeE_TextChanged;
            // 
            // txtvolumeF
            // 
            txtvolumeF.Location = new Point(326, 233);
            txtvolumeF.Name = "txtvolumeF";
            txtvolumeF.Size = new Size(125, 27);
            txtvolumeF.TabIndex = 21;
            txtvolumeF.TextChanged += txtvolumeF_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 28);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 22;
            label5.Text = "Volume";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 645);
            Controls.Add(label5);
            Controls.Add(txtvolumeF);
            Controls.Add(txtvolumeE);
            Controls.Add(txtvolumeD);
            Controls.Add(txtvolumeC);
            Controls.Add(txtvolumeB);
            Controls.Add(txtvolumeA);
            Controls.Add(label4);
            Controls.Add(txtweightF);
            Controls.Add(label3);
            Controls.Add(txtweightE);
            Controls.Add(label2);
            Controls.Add(txtweightD);
            Controls.Add(label1);
            Controls.Add(splitter1);
            Controls.Add(grprun);
            Controls.Add(txtweightB);
            Controls.Add(lblB);
            Controls.Add(txtweightC);
            Controls.Add(lblC);
            Controls.Add(txtWeightA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grprun.ResumeLayout(false);
            grprun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblA;
        private TextBox txtWeightA;
        private TextBox txtweightC;
        private Label lblC;
        private TextBox txtweightB;
        private Label lblB;
        private GroupBox grprun;
        private NumericUpDown numericUpDown1;
        private Button Start;
        private TextBox txtresult;
        private Splitter splitter1;
        private TextBox txtweightD;
        private Label label1;
        private TextBox txtweightE;
        private Label label2;
        private TextBox txtweightF;
        private Label label3;
        private Label label4;
        private TextBox txtvolumeA;
        private TextBox txtvolumeB;
        private TextBox txtvolumeC;
        private TextBox txtvolumeD;
        private TextBox txtvolumeE;
        private TextBox txtvolumeF;
        private Label label5;
        private TextBox txtHint;
    }
}