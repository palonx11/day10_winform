namespace _7._2._68
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
            question_text = new TextBox();
            solution_textbox = new TextBox();
            solution_label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(478, 45);
            button1.Name = "button1";
            button1.Size = new Size(114, 78);
            button1.TabIndex = 0;
            button1.Text = "คำนวณ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // question_text
            // 
            question_text.Location = new Point(190, 52);
            question_text.Multiline = true;
            question_text.Name = "question_text";
            question_text.Size = new Size(238, 71);
            question_text.TabIndex = 1;
            question_text.TextChanged += question_text_TextChanged;
            // 
            // solution_textbox
            // 
            solution_textbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solution_textbox.ForeColor = SystemColors.MenuHighlight;
            solution_textbox.Location = new Point(190, 148);
            solution_textbox.Multiline = true;
            solution_textbox.Name = "solution_textbox";
            solution_textbox.Size = new Size(129, 77);
            solution_textbox.TabIndex = 2;
            solution_textbox.Text = "0";
            solution_textbox.TextChanged += solution_textbox_TextChanged;
            // 
            // solution_label
            // 
            solution_label.AutoSize = true;
            solution_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solution_label.ForeColor = Color.Red;
            solution_label.Location = new Point(392, 193);
            solution_label.Name = "solution_label";
            solution_label.Size = new Size(27, 32);
            solution_label.TabIndex = 3;
            solution_label.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(solution_label);
            Controls.Add(solution_textbox);
            Controls.Add(question_text);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox question_text;
        private TextBox solution_textbox;
        private Label solution_label;
    }
}
