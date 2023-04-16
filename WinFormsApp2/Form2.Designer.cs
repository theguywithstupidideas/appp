namespace Ultilib_GUI
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            label7 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(label8);
            tabPage4.Location = new Point(4, 25);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 397);
            tabPage4.TabIndex = 7;
            tabPage4.Text = "Benzina";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(227, 223);
            label7.Name = "label7";
            label7.Size = new Size(144, 36);
            label7.TabIndex = 3;
            label7.Text = "Risultato:  ";
            // 
            // button4
            // 
            button4.Location = new Point(221, 146);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Vai!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(302, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Small", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(275, 36);
            label8.Name = "label8";
            label8.Size = new Size(198, 64);
            label8.TabIndex = 0;
            label8.Text = "Benzina";
            label8.Click += label8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing_1;
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage4;
        private Label label7;
        private Button button4;
        private TextBox textBox4;
        private Label label8;
    }
}