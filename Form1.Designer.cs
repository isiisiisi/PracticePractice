namespace PracticePractice
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResult = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnClear = new Button();
            btnBack = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEquals = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnPara1 = new Button();
            btnPara2 = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 3;
            label1.Text = "Basic Calculator";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += Label1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.FlatStyle = FlatStyle.Flat;
            lblResult.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(64, 64, 64);
            lblResult.Location = new Point(21, 132);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(92, 37);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            lblResult.TextAlign = ContentAlignment.TopRight;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn7.Location = new Point(27, 267);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn8.Location = new Point(105, 267);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn9.Location = new Point(182, 267);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Btn9_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(182, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 70);
            btnClear.TabIndex = 8;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F);
            btnBack.Location = new Point(259, 190);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 70);
            btnBack.TabIndex = 9;
            btnBack.Text = "⬅";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Button5_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnMultiply.Location = new Point(259, 345);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(70, 70);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnDivide.Location = new Point(259, 267);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(70, 70);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnDivide_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn6.Location = new Point(182, 345);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn5.Location = new Point(105, 345);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn4.Location = new Point(27, 345);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Button10_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnAdd.Location = new Point(259, 502);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnSubtract.Location = new Point(259, 423);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(70, 70);
            btnSubtract.TabIndex = 18;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BtnSubtract_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn3.Location = new Point(182, 423);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn2.Location = new Point(105, 423);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn1.Location = new Point(29, 423);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 70);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Btn1_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnEquals.Location = new Point(182, 502);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(70, 70);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += BtnEquals_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn0.Location = new Point(105, 502);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 70);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Button17_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnDecimal.Location = new Point(29, 502);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(70, 70);
            btnDecimal.TabIndex = 22;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += BtnDecimal_Click;
            // 
            // btnPara1
            // 
            btnPara1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPara1.Location = new Point(29, 190);
            btnPara1.Name = "btnPara1";
            btnPara1.Size = new Size(68, 70);
            btnPara1.TabIndex = 23;
            btnPara1.Text = "(";
            btnPara1.UseVisualStyleBackColor = true;
            btnPara1.Click += BtnPara1_Click;
            // 
            // btnPara2
            // 
            btnPara2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPara2.Location = new Point(105, 190);
            btnPara2.Name = "btnPara2";
            btnPara2.Size = new Size(70, 70);
            btnPara2.TabIndex = 24;
            btnPara2.Text = ")";
            btnPara2.UseVisualStyleBackColor = true;
            btnPara2.Click += btnPara2_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.White;
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            txtResult.Location = new Point(29, 75);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(300, 52);
            txtResult.TabIndex = 26;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // calculator
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(361, 618);
            Controls.Add(txtResult);
            Controls.Add(btnPara2);
            Controls.Add(btnPara1);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnEquals);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(lblResult);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "&";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblResult;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnClear;
        private Button btnBack;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEquals;
        private Button btn0;
        private Button btnDecimal;
        private Button btnPara1;
        private Button btnPara2;
        private TextBox txtResult;
        
    }
}
