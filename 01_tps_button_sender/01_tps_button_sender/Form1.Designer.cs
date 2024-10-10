namespace _01_tps_button_sender
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            label_fissa_turno = new Label();
            label_turno = new Label();
            label_fissa_timer = new Label();
            label_timer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            oneSec_timer = new System.Windows.Forms.Timer(components);
            text_vittorie = new Label();
            label1 = new Label();
            label2 = new Label();
            label_winX = new Label();
            label_winO = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 50);
            button1.Name = "button1";
            button1.Size = new Size(100, 83);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(200, 50);
            button2.Name = "button2";
            button2.Size = new Size(100, 83);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(350, 50);
            button3.Name = "button3";
            button3.Size = new Size(100, 83);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(350, 174);
            button6.Name = "button6";
            button6.Size = new Size(100, 83);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(200, 174);
            button5.Name = "button5";
            button5.Size = new Size(100, 83);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(50, 174);
            button4.Name = "button4";
            button4.Size = new Size(100, 83);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(350, 298);
            button9.Name = "button9";
            button9.Size = new Size(100, 83);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(200, 298);
            button8.Name = "button8";
            button8.Size = new Size(100, 83);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(50, 298);
            button7.Name = "button7";
            button7.Size = new Size(100, 83);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // label_fissa_turno
            // 
            label_fissa_turno.AutoSize = true;
            label_fissa_turno.Font = new Font("Segoe UI", 12F);
            label_fissa_turno.Location = new Point(568, 68);
            label_fissa_turno.Name = "label_fissa_turno";
            label_fissa_turno.Size = new Size(97, 21);
            label_fissa_turno.TabIndex = 9;
            label_fissa_turno.Text = "E' il turno di ";
            // 
            // label_turno
            // 
            label_turno.AutoSize = true;
            label_turno.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_turno.Location = new Point(662, 68);
            label_turno.Name = "label_turno";
            label_turno.Size = new Size(0, 21);
            label_turno.TabIndex = 10;
            // 
            // label_fissa_timer
            // 
            label_fissa_timer.AutoSize = true;
            label_fissa_timer.Font = new Font("Segoe UI", 12F);
            label_fissa_timer.Location = new Point(568, 112);
            label_fissa_timer.Name = "label_fissa_timer";
            label_fissa_timer.Size = new Size(78, 21);
            label_fissa_timer.TabIndex = 11;
            label_fissa_timer.Text = "Scade tra ";
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_timer.Location = new Point(662, 112);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(0, 21);
            label_timer.TabIndex = 12;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 5000;
            timer.Tick += timer_Tick;
            // 
            // oneSec_timer
            // 
            oneSec_timer.Enabled = true;
            oneSec_timer.Interval = 1000;
            oneSec_timer.Tick += oneSec_timer_Tick;
            // 
            // text_vittorie
            // 
            text_vittorie.AutoSize = true;
            text_vittorie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_vittorie.ForeColor = Color.IndianRed;
            text_vittorie.Location = new Point(569, 307);
            text_vittorie.Name = "text_vittorie";
            text_vittorie.Size = new Size(111, 21);
            text_vittorie.TabIndex = 13;
            text_vittorie.Text = "PARTITE VINTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(569, 340);
            label1.Name = "label1";
            label1.Size = new Size(17, 17);
            label1.TabIndex = 14;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(568, 364);
            label2.Name = "label2";
            label2.Size = new Size(18, 17);
            label2.TabIndex = 15;
            label2.Text = "O";
            // 
            // label_winX
            // 
            label_winX.AutoSize = true;
            label_winX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_winX.ForeColor = Color.IndianRed;
            label_winX.Location = new Point(629, 340);
            label_winX.Name = "label_winX";
            label_winX.Size = new Size(0, 17);
            label_winX.TabIndex = 16;
            // 
            // label_winO
            // 
            label_winO.AutoSize = true;
            label_winO.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_winO.ForeColor = Color.IndianRed;
            label_winO.Location = new Point(629, 364);
            label_winO.Name = "label_winO";
            label_winO.Size = new Size(0, 17);
            label_winO.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_winO);
            Controls.Add(label_winX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_vittorie);
            Controls.Add(label_timer);
            Controls.Add(label_fissa_timer);
            Controls.Add(label_turno);
            Controls.Add(label_fissa_turno);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TRIS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label_fissa_turno;
        private Label label_turno;
        private Label label_fissa_timer;
        private Label label_timer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer oneSec_timer;
        private Label text_vittorie;
        private Label label1;
        private Label label2;
        private Label label_winX;
        private Label label_winO;
    }
}
