namespace ClientServerChat
{
    partial class MainWindow
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
            domainUpDown1 = new DomainUpDown();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            bindingSource1 = new BindingSource(components);
            textBox3 = new TextBox();
            vScrollBar1 = new VScrollBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(601, 12);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(67, 23);
            domainUpDown1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(674, 12);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(domainUpDown1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Serveur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 14);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Port :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(524, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Alias :";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 332);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Message";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(709, 350);
            button2.Name = "button2";
            button2.Size = new Size(79, 88);
            button2.TabIndex = 5;
            button2.Text = "Envoyer";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 118);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 211);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 335);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(691, 103);
            textBox3.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(686, 335);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 103);
            vScrollBar1.TabIndex = 8;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox3);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "MainWindow";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown domainUpDown1;
        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button2;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private BindingSource bindingSource1;
        private TextBox textBox3;
        private VScrollBar vScrollBar1;
    }
}