namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 50);
            button1.Name = "button1";
            button1.Size = new Size(225, 82);
            button1.TabIndex = 0;
            button1.Text = "Выбрать файл 1 откуда копировать ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 50);
            button2.Name = "button2";
            button2.Size = new Size(225, 82);
            button2.TabIndex = 1;
            button2.Text = "Выбрать файл 1 куда копировать ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(52, 166);
            button3.Name = "button3";
            button3.Size = new Size(225, 82);
            button3.TabIndex = 2;
            button3.Text = "Выбрать файл 2 откуда копировать ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(409, 166);
            button4.Name = "button4";
            button4.Size = new Size(225, 82);
            button4.TabIndex = 3;
            button4.Text = "Выбрать файл 2 куда копировать ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(54, 276);
            button5.Name = "button5";
            button5.Size = new Size(223, 23);
            button5.TabIndex = 4;
            button5.Text = "Начать загрузку";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(411, 276);
            button6.Name = "button6";
            button6.Size = new Size(223, 23);
            button6.TabIndex = 5;
            button6.Text = "Начать запись";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(54, 337);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(580, 23);
            progressBar1.TabIndex = 6;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(54, 393);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(580, 23);
            progressBar2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
    }
}
