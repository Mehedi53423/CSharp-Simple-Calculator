namespace Simple_Calculetor
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(55, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(202, 167);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(127, 23);
            this.subButton.TabIndex = 3;
            this.subButton.Text = "Subtract";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.Location = new System.Drawing.Point(55, 205);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(127, 23);
            this.multiButton.TabIndex = 4;
            this.multiButton.Text = "Multiply";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(202, 205);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(127, 23);
            this.divButton.TabIndex = 5;
            this.divButton.Text = "Divide";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

