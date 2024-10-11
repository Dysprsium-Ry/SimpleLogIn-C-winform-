namespace MyCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnSubt = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnNeg = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSq2 = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDisplay.Location = new System.Drawing.Point(20, 79);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(368, 55);
            this.txtDisplay.TabIndex = 99;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(20, 387);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(5);
            this.btn1.Size = new System.Drawing.Size(68, 59);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(95, 387);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(5);
            this.btn2.Size = new System.Drawing.Size(68, 59);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(170, 387);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(5);
            this.btn3.Size = new System.Drawing.Size(68, 59);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Red;
            this.btn4.Location = new System.Drawing.Point(20, 312);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(5);
            this.btn4.Size = new System.Drawing.Size(68, 59);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Red;
            this.btn5.Location = new System.Drawing.Point(95, 312);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(5);
            this.btn5.Size = new System.Drawing.Size(68, 59);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Red;
            this.btn6.Location = new System.Drawing.Point(170, 312);
            this.btn6.Name = "btn6";
            this.btn6.Padding = new System.Windows.Forms.Padding(5);
            this.btn6.Size = new System.Drawing.Size(68, 59);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Red;
            this.btn7.Location = new System.Drawing.Point(20, 237);
            this.btn7.Name = "btn7";
            this.btn7.Padding = new System.Windows.Forms.Padding(5);
            this.btn7.Size = new System.Drawing.Size(68, 59);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Red;
            this.btn8.Location = new System.Drawing.Point(95, 237);
            this.btn8.Name = "btn8";
            this.btn8.Padding = new System.Windows.Forms.Padding(5);
            this.btn8.Size = new System.Drawing.Size(68, 59);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Red;
            this.btn9.Location = new System.Drawing.Point(170, 237);
            this.btn9.Name = "btn9";
            this.btn9.Padding = new System.Windows.Forms.Padding(5);
            this.btn9.Size = new System.Drawing.Size(68, 59);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(245, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(68, 134);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnOpertr_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompute.BackColor = System.Drawing.Color.Transparent;
            this.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.Red;
            this.btnCompute.Location = new System.Drawing.Point(245, 387);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Padding = new System.Windows.Forms.Padding(5);
            this.btnCompute.Size = new System.Drawing.Size(68, 59);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "=";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(320, 387);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(5);
            this.button12.Size = new System.Drawing.Size(68, 59);
            this.button12.TabIndex = 12;
            this.button12.Text = "÷";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnOpertr_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubt.BackColor = System.Drawing.Color.Transparent;
            this.btnSubt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubt.ForeColor = System.Drawing.Color.Red;
            this.btnSubt.Location = new System.Drawing.Point(320, 237);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Padding = new System.Windows.Forms.Padding(5);
            this.btnSubt.Size = new System.Drawing.Size(68, 59);
            this.btnSubt.TabIndex = 13;
            this.btnSubt.Text = "-";
            this.btnSubt.UseVisualStyleBackColor = false;
            this.btnSubt.Click += new System.EventHandler(this.btnOpertr_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(320, 312);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(5);
            this.button14.Size = new System.Drawing.Size(68, 59);
            this.button14.TabIndex = 14;
            this.button14.Text = "×";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnOpertr_Click);
            // 
            // btnNeg
            // 
            this.btnNeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNeg.BackColor = System.Drawing.Color.Transparent;
            this.btnNeg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeg.ForeColor = System.Drawing.Color.Red;
            this.btnNeg.Location = new System.Drawing.Point(170, 155);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Padding = new System.Windows.Forms.Padding(5);
            this.btnNeg.Size = new System.Drawing.Size(105, 66);
            this.btnNeg.TabIndex = 21;
            this.btnNeg.Text = "Negate";
            this.btnNeg.UseVisualStyleBackColor = false;
            this.btnNeg.Click += new System.EventHandler(this.btnNeg_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(282, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5);
            this.btnClear.Size = new System.Drawing.Size(106, 66);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.CausesValidation = false;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Red;
            this.btn0.Location = new System.Drawing.Point(17, 462);
            this.btn0.Name = "btn0";
            this.btn0.Padding = new System.Windows.Forms.Padding(5);
            this.btn0.Size = new System.Drawing.Size(221, 59);
            this.btn0.TabIndex = 25;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDot
            // 
            this.btnDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDot.BackColor = System.Drawing.Color.Transparent;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.Red;
            this.btnDot.Location = new System.Drawing.Point(245, 462);
            this.btnDot.Name = "btnDot";
            this.btnDot.Padding = new System.Windows.Forms.Padding(5);
            this.btnDot.Size = new System.Drawing.Size(68, 59);
            this.btnDot.TabIndex = 26;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(320, 462);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(5);
            this.btnDel.Size = new System.Drawing.Size(68, 59);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "⌫";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSq2
            // 
            this.btnSq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSq2.BackColor = System.Drawing.Color.Transparent;
            this.btnSq2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSq2.ForeColor = System.Drawing.Color.Red;
            this.btnSq2.Location = new System.Drawing.Point(20, 155);
            this.btnSq2.Name = "btnSq2";
            this.btnSq2.Padding = new System.Windows.Forms.Padding(5);
            this.btnSq2.Size = new System.Drawing.Size(143, 66);
            this.btnSq2.TabIndex = 16;
            this.btnSq2.Text = "x^2";
            this.btnSq2.UseVisualStyleBackColor = false;
            this.btnSq2.Click += new System.EventHandler(this.btnSq2_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreview.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPreview.Location = new System.Drawing.Point(20, 47);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPreview.Size = new System.Drawing.Size(368, 33);
            this.txtPreview.TabIndex = 28;
            this.txtPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreview.TextChanged += new System.EventHandler(this.txtPreview_TextChanged);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTitleBar.Controls.Add(this.txtTitle);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(5, 5);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(400, 28);
            this.panelTitleBar.TabIndex = 100;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(32, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(110, 18);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "__Yozo Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(363, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(37, 28);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 546);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSq2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnSubt);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "__Yozo-Calculator";
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnNeg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSq2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtPreview;
    }
}

