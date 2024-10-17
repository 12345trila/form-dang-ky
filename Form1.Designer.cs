namespace form_dangky
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ten = new TextBox();
            email = new TextBox();
            Pass = new TextBox();
            button_dangky = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(291, 127);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 220);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 182);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 272);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // ten
            // 
            ten.Location = new Point(291, 179);
            ten.Name = "ten";
            ten.Size = new Size(198, 27);
            ten.TabIndex = 4;
            // 
            // email
            // 
            email.Location = new Point(291, 213);
            email.Name = "email";
            email.Size = new Size(198, 27);
            email.TabIndex = 5;
            // 
            // Pass
            // 
            Pass.Location = new Point(291, 265);
            Pass.Name = "Pass";
            Pass.Size = new Size(198, 27);
            Pass.TabIndex = 6;
            Pass.UseSystemPasswordChar = true;
            // 
            // button_dangky
            // 
            button_dangky.Location = new Point(298, 325);
            button_dangky.Name = "button_dangky";
            button_dangky.Size = new Size(94, 29);
            button_dangky.TabIndex = 7;
            button_dangky.Text = "Đăng ký";
            button_dangky.UseVisualStyleBackColor = true;
            button_dangky.Click += button_dangky_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_dangky);
            Controls.Add(Pass);
            Controls.Add(email);
            Controls.Add(ten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ten;
        private TextBox email;
        private TextBox Pass;
        private Button button_dangky;
    }
}
