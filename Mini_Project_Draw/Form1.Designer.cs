namespace Mini_Project_Draw
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
            Choice = new GroupBox();
            Rectangle = new RadioButton();
            Circle = new RadioButton();
            Line = new RadioButton();
            Choice.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 33);
            button1.Name = "button1";
            button1.Size = new Size(79, 36);
            button1.TabIndex = 0;
            button1.Text = "화면 초기화";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(472, 73);
            button2.Name = "button2";
            button2.Size = new Size(79, 36);
            button2.TabIndex = 1;
            button2.Text = "빨강";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_red;
            // 
            // button3
            // 
            button3.Location = new Point(571, 73);
            button3.Name = "button3";
            button3.Size = new Size(79, 36);
            button3.TabIndex = 2;
            button3.Text = "노랑";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(668, 73);
            button4.Name = "button4";
            button4.Size = new Size(79, 36);
            button4.TabIndex = 3;
            button4.Text = "파랑";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Choice
            // 
            Choice.Controls.Add(Rectangle);
            Choice.Controls.Add(Circle);
            Choice.Controls.Add(Line);
            Choice.Location = new Point(476, 12);
            Choice.Name = "Choice";
            Choice.Size = new Size(271, 55);
            Choice.TabIndex = 4;
            Choice.TabStop = false;
            Choice.Text = "종류";
            // 
            // Rectangle
            // 
            Rectangle.AutoSize = true;
            Rectangle.Location = new Point(166, 22);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(61, 19);
            Rectangle.TabIndex = 2;
            Rectangle.TabStop = true;
            Rectangle.Text = "사각형";
            Rectangle.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            Circle.AutoSize = true;
            Circle.Location = new Point(95, 22);
            Circle.Name = "Circle";
            Circle.Size = new Size(37, 19);
            Circle.TabIndex = 1;
            Circle.TabStop = true;
            Circle.Text = "원";
            Circle.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            Line.AutoSize = true;
            Line.Location = new Point(21, 22);
            Line.Name = "Line";
            Line.Size = new Size(37, 19);
            Line.TabIndex = 0;
            Line.TabStop = true;
            Line.Text = "선";
            Line.UseVisualStyleBackColor = true;
            Line.CheckedChanged += Line_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Choice);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            Choice.ResumeLayout(false);
            Choice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox Choice;
        private RadioButton Rectangle;
        private RadioButton Circle;
        private RadioButton Line;
    }
}