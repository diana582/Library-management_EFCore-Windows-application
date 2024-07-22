namespace LibraryDemo
{
    partial class bookdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookdata));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(250, 39);
            label1.Name = "label1";
            label1.Size = new Size(289, 46);
            label1.TabIndex = 0;
            label1.Text = "Enter Book details";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(166, 159);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 2;
            label3.Text = "Book name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.CornflowerBlue;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(166, 223);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 3;
            label4.Text = "Book count";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientActiveCaption;
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(374, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 36);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(374, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 36);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(65, 316);
            button1.Name = "button1";
            button1.Size = new Size(126, 48);
            button1.TabIndex = 7;
            button1.Text = "Add details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(229, 316);
            button2.Name = "button2";
            button2.Size = new Size(135, 48);
            button2.TabIndex = 8;
            button2.Text = "Edit details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(400, 316);
            button3.Name = "button3";
            button3.Size = new Size(122, 48);
            button3.TabIndex = 9;
            button3.Text = "Delete book";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(578, 316);
            button4.Name = "button4";
            button4.Size = new Size(149, 48);
            button4.TabIndex = 10;
            button4.Text = "Display all books";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // bookdata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "bookdata";
            Text = "bookdata";
            Load += bookdata_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}