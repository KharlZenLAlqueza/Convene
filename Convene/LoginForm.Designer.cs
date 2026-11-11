namespace Convene
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbx_conveneicon = new PictureBox();
            lb_convene = new Label();
            label3 = new Label();
            label4 = new Label();
            pnl_signinandcreate = new RoundedPanel();
            pnl_signinselect = new RoundedPanel();
            lb_signin = new Label();
            pnl_createaccselect = new RoundedPanel();
            lb_createacc = new Label();
            label7 = new Label();
            roundedPanel3 = new RoundedPanel();
            txtLoginUsername = new TextBox();
            roundedPanel4 = new RoundedPanel();
            txtLoginPassword = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            btnSignin = new RoundedPanel();
            label16 = new Label();
            pnl_signinsection = new Panel();
            pnl_createaccountsection = new Panel();
            btnRegister = new RoundedPanel();
            label5 = new Label();
            roundedPanel1 = new RoundedPanel();
            txtRegConfirm = new TextBox();
            roundedPanel2 = new RoundedPanel();
            txtRegPassword = new TextBox();
            roundedPanel5 = new RoundedPanel();
            txtRegUsername = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_conveneicon).BeginInit();
            pnl_signinandcreate.SuspendLayout();
            pnl_signinselect.SuspendLayout();
            pnl_createaccselect.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            btnSignin.SuspendLayout();
            pnl_signinsection.SuspendLayout();
            pnl_createaccountsection.SuspendLayout();
            btnRegister.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 35, 71);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.FromArgb(201, 204, 232);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 673);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(527, 165);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 332);
            label2.Name = "label2";
            label2.Size = new Size(434, 40);
            label2.TabIndex = 3;
            label2.Text = "Propose a time block, let your group vote, and lock it into the \r\ncalendar once enough people approve.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 211);
            label1.Name = "label1";
            label1.Size = new Size(387, 108);
            label1.TabIndex = 2;
            label1.Text = "Agree on the time, \r\ntogether\r\n";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.17757F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.82243F));
            tableLayoutPanel1.Controls.Add(pbx_conveneicon, 0, 0);
            tableLayoutPanel1.Controls.Add(lb_convene, 1, 0);
            tableLayoutPanel1.Location = new Point(60, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(257, 103);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pbx_conveneicon
            // 
            pbx_conveneicon.Dock = DockStyle.Fill;
            pbx_conveneicon.Image = (Image)resources.GetObject("pbx_conveneicon.Image");
            pbx_conveneicon.Location = new Point(8, 8);
            pbx_conveneicon.Name = "pbx_conveneicon";
            pbx_conveneicon.Size = new Size(75, 87);
            pbx_conveneicon.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx_conveneicon.TabIndex = 0;
            pbx_conveneicon.TabStop = false;
            // 
            // lb_convene
            // 
            lb_convene.AutoSize = true;
            lb_convene.Dock = DockStyle.Fill;
            lb_convene.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_convene.ForeColor = Color.FromArgb(245, 246, 251);
            lb_convene.Location = new Point(89, 5);
            lb_convene.Name = "lb_convene";
            lb_convene.Size = new Size(160, 93);
            lb_convene.TabIndex = 1;
            lb_convene.Text = "CONVENE";
            lb_convene.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(726, 130);
            label3.Name = "label3";
            label3.Size = new Size(207, 38);
            label3.TabIndex = 5;
            label3.Text = "Welcome back\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(737, 179);
            label4.Name = "label4";
            label4.Size = new Size(185, 17);
            label4.TabIndex = 6;
            label4.Text = "Sign in to see your schedules\r\n";
            // 
            // pnl_signinandcreate
            // 
            pnl_signinandcreate.BackColor = Color.FromArgb(236, 235, 254);
            pnl_signinandcreate.BorderColor = Color.FromArgb(224, 224, 224);
            pnl_signinandcreate.BorderRadius = 10;
            pnl_signinandcreate.BorderSize = 2;
            pnl_signinandcreate.Controls.Add(pnl_signinselect);
            pnl_signinandcreate.Controls.Add(pnl_createaccselect);
            pnl_signinandcreate.Location = new Point(737, 224);
            pnl_signinandcreate.Name = "pnl_signinandcreate";
            pnl_signinandcreate.Padding = new Padding(5);
            pnl_signinandcreate.Size = new Size(423, 52);
            pnl_signinandcreate.TabIndex = 7;
            // 
            // pnl_signinselect
            // 
            pnl_signinselect.BackColor = Color.FromArgb(248, 248, 255);
            pnl_signinselect.BorderColor = Color.FromArgb(224, 224, 224);
            pnl_signinselect.BorderRadius = 10;
            pnl_signinselect.BorderSize = 2;
            pnl_signinselect.Controls.Add(lb_signin);
            pnl_signinselect.Dock = DockStyle.Left;
            pnl_signinselect.Location = new Point(5, 5);
            pnl_signinselect.Name = "pnl_signinselect";
            pnl_signinselect.Size = new Size(200, 42);
            pnl_signinselect.TabIndex = 3;
            pnl_signinselect.Click += pnl_signinselect_Click;
            pnl_signinselect.Paint += pnl_signinselect_Paint;
            // 
            // lb_signin
            // 
            lb_signin.AutoSize = true;
            lb_signin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_signin.ForeColor = Color.FromArgb(79, 70, 229);
            lb_signin.Location = new Point(65, 11);
            lb_signin.Name = "lb_signin";
            lb_signin.Size = new Size(66, 23);
            lb_signin.TabIndex = 2;
            lb_signin.Text = "Sign in";
            lb_signin.Click += pnl_signinselect_Click;
            // 
            // pnl_createaccselect
            // 
            pnl_createaccselect.BackColor = Color.Transparent;
            pnl_createaccselect.BorderColor = Color.Transparent;
            pnl_createaccselect.BorderRadius = 10;
            pnl_createaccselect.BorderSize = 2;
            pnl_createaccselect.Controls.Add(lb_createacc);
            pnl_createaccselect.Dock = DockStyle.Right;
            pnl_createaccselect.Location = new Point(211, 5);
            pnl_createaccselect.Name = "pnl_createaccselect";
            pnl_createaccselect.Size = new Size(207, 42);
            pnl_createaccselect.TabIndex = 2;
            pnl_createaccselect.Click += pnl_createacc_Click;
            pnl_createaccselect.Paint += pnl_createaccselect_Paint;
            // 
            // lb_createacc
            // 
            lb_createacc.AutoSize = true;
            lb_createacc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_createacc.ForeColor = Color.Gray;
            lb_createacc.Location = new Point(34, 11);
            lb_createacc.Name = "lb_createacc";
            lb_createacc.Size = new Size(132, 23);
            lb_createacc.TabIndex = 1;
            lb_createacc.Text = "Create Account";
            lb_createacc.Click += pnl_createacc_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(4, 22);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 8;
            label7.Text = "Username";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(248, 248, 255);
            roundedPanel3.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel3.BorderRadius = 10;
            roundedPanel3.BorderSize = 2;
            roundedPanel3.Controls.Add(txtLoginUsername);
            roundedPanel3.Location = new Point(3, 51);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Padding = new Padding(5);
            roundedPanel3.Size = new Size(424, 53);
            roundedPanel3.TabIndex = 9;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLoginUsername.BackColor = Color.GhostWhite;
            txtLoginUsername.BorderStyle = BorderStyle.None;
            txtLoginUsername.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginUsername.Location = new Point(5, 5);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(414, 38);
            txtLoginUsername.TabIndex = 0;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(248, 248, 255);
            roundedPanel4.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel4.BorderRadius = 10;
            roundedPanel4.BorderSize = 2;
            roundedPanel4.Controls.Add(txtLoginPassword);
            roundedPanel4.Location = new Point(3, 155);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Padding = new Padding(5);
            roundedPanel4.Size = new Size(424, 53);
            roundedPanel4.TabIndex = 11;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLoginPassword.BackColor = Color.GhostWhite;
            txtLoginPassword.BorderStyle = BorderStyle.None;
            txtLoginPassword.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPassword.Location = new Point(8, 7);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(414, 38);
            txtLoginPassword.TabIndex = 1;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(4, 126);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 10;
            label8.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(4, 229);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Keep me signed in";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(79, 70, 229);
            btnSignin.BorderColor = Color.DimGray;
            btnSignin.BorderRadius = 10;
            btnSignin.BorderSize = 2;
            btnSignin.Controls.Add(label16);
            btnSignin.Location = new Point(3, 315);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(419, 61);
            btnSignin.TabIndex = 14;
            btnSignin.Click += btnSignIn_Click;
            btnSignin.Paint += roundedPanel10_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(171, 22);
            label16.Name = "label16";
            label16.Size = new Size(66, 23);
            label16.TabIndex = 0;
            label16.Text = "Sign In";
            label16.Click += btnSignIn_Click;
            // 
            // pnl_signinsection
            // 
            pnl_signinsection.Controls.Add(roundedPanel3);
            pnl_signinsection.Controls.Add(btnSignin);
            pnl_signinsection.Controls.Add(checkBox1);
            pnl_signinsection.Controls.Add(label7);
            pnl_signinsection.Controls.Add(roundedPanel4);
            pnl_signinsection.Controls.Add(label8);
            pnl_signinsection.Location = new Point(736, 282);
            pnl_signinsection.Name = "pnl_signinsection";
            pnl_signinsection.Size = new Size(424, 379);
            pnl_signinsection.TabIndex = 15;
            // 
            // pnl_createaccountsection
            // 
            pnl_createaccountsection.Controls.Add(btnRegister);
            pnl_createaccountsection.Controls.Add(roundedPanel1);
            pnl_createaccountsection.Controls.Add(roundedPanel2);
            pnl_createaccountsection.Controls.Add(roundedPanel5);
            pnl_createaccountsection.Controls.Add(label6);
            pnl_createaccountsection.Controls.Add(label9);
            pnl_createaccountsection.Controls.Add(label10);
            pnl_createaccountsection.Location = new Point(736, 285);
            pnl_createaccountsection.Name = "pnl_createaccountsection";
            pnl_createaccountsection.Size = new Size(427, 379);
            pnl_createaccountsection.TabIndex = 22;
            pnl_createaccountsection.Visible = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(79, 70, 229);
            btnRegister.BorderColor = Color.DimGray;
            btnRegister.BorderRadius = 10;
            btnRegister.BorderSize = 2;
            btnRegister.Controls.Add(label5);
            btnRegister.Location = new Point(2, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(419, 61);
            btnRegister.TabIndex = 15;
            btnRegister.Click += btnRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(171, 22);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 0;
            label5.Text = "Register";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(248, 248, 255);
            roundedPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel1.BorderRadius = 10;
            roundedPanel1.BorderSize = 2;
            roundedPanel1.Controls.Add(txtRegConfirm);
            roundedPanel1.Location = new Point(5, 195);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5);
            roundedPanel1.Size = new Size(424, 53);
            roundedPanel1.TabIndex = 12;
            // 
            // txtRegConfirm
            // 
            txtRegConfirm.BackColor = Color.GhostWhite;
            txtRegConfirm.BorderStyle = BorderStyle.None;
            txtRegConfirm.Dock = DockStyle.Fill;
            txtRegConfirm.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegConfirm.Location = new Point(5, 5);
            txtRegConfirm.Name = "txtRegConfirm";
            txtRegConfirm.Size = new Size(414, 38);
            txtRegConfirm.TabIndex = 0;
            txtRegConfirm.UseSystemPasswordChar = true;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(248, 248, 255);
            roundedPanel2.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel2.BorderRadius = 10;
            roundedPanel2.BorderSize = 2;
            roundedPanel2.Controls.Add(txtRegPassword);
            roundedPanel2.Location = new Point(5, 107);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new Padding(5);
            roundedPanel2.Size = new Size(424, 53);
            roundedPanel2.TabIndex = 11;
            // 
            // txtRegPassword
            // 
            txtRegPassword.BackColor = Color.GhostWhite;
            txtRegPassword.BorderStyle = BorderStyle.None;
            txtRegPassword.Dock = DockStyle.Fill;
            txtRegPassword.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegPassword.Location = new Point(5, 5);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(414, 38);
            txtRegPassword.TabIndex = 0;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(248, 248, 255);
            roundedPanel5.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel5.BorderRadius = 10;
            roundedPanel5.BorderSize = 2;
            roundedPanel5.Controls.Add(txtRegUsername);
            roundedPanel5.Location = new Point(3, 31);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(5);
            roundedPanel5.Size = new Size(424, 53);
            roundedPanel5.TabIndex = 10;
            // 
            // txtRegUsername
            // 
            txtRegUsername.BackColor = Color.GhostWhite;
            txtRegUsername.BorderStyle = BorderStyle.None;
            txtRegUsername.Dock = DockStyle.Fill;
            txtRegUsername.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegUsername.Location = new Point(5, 5);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(414, 38);
            txtRegUsername.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 175);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(4, 4);
            label9.Name = "label9";
            label9.Size = new Size(69, 17);
            label9.TabIndex = 8;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(5, 87);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 10;
            label10.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnl_createaccountsection);
            Controls.Add(pnl_signinsection);
            Controls.Add(pnl_signinandcreate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(91, 98, 126);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_conveneicon).EndInit();
            pnl_signinandcreate.ResumeLayout(false);
            pnl_signinselect.ResumeLayout(false);
            pnl_signinselect.PerformLayout();
            pnl_createaccselect.ResumeLayout(false);
            pnl_createaccselect.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            btnSignin.ResumeLayout(false);
            btnSignin.PerformLayout();
            pnl_signinsection.ResumeLayout(false);
            pnl_signinsection.PerformLayout();
            pnl_createaccountsection.ResumeLayout(false);
            pnl_createaccountsection.PerformLayout();
            btnRegister.ResumeLayout(false);
            btnRegister.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbx_conveneicon;
        private Label lb_convene;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private RoundedPanel pnl_signinandcreate;
        private Label label7;
        private RoundedPanel roundedPanel3;
        private TextBox txtLoginUsername;
        private RoundedPanel roundedPanel4;
        private Label label8;
        private TextBox txtLoginPassword;
        private CheckBox checkBox1;
        private RoundedPanel btnSignin;
        private Label label16;
        private RoundedPanel pnl_signinselect;
        private Label lb_signin;
        private RoundedPanel pnl_createaccselect;
        private Label lb_createacc;
        private Panel pnl_signinsection;
        private Panel pnl_createaccountsection;
        private RoundedPanel btnRegister;
        private Label label5;
        private RoundedPanel roundedPanel1;
        private TextBox txtRegConfirm;
        private RoundedPanel roundedPanel2;
        private TextBox txtRegPassword;
        private RoundedPanel roundedPanel5;
        private TextBox txtRegUsername;
        private Label label6;
        private Label label9;
        private Label label10;
    }
}