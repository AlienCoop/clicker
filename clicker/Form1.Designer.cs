namespace clicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RightMouseButton = new System.Windows.Forms.RadioButton();
            this.ScrollWheelButton = new System.Windows.Forms.RadioButton();
            this.LeftMouseButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CurrentPositionButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightMouseButton);
            this.groupBox1.Controls.Add(this.ScrollWheelButton);
            this.groupBox1.Controls.Add(this.LeftMouseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse";
            // 
            // RightMouseButton
            // 
            this.RightMouseButton.AutoSize = true;
            this.RightMouseButton.Location = new System.Drawing.Point(253, 28);
            this.RightMouseButton.Name = "RightMouseButton";
            this.RightMouseButton.Size = new System.Drawing.Size(84, 17);
            this.RightMouseButton.TabIndex = 2;
            this.RightMouseButton.TabStop = true;
            this.RightMouseButton.Text = "Right mouse";
            this.RightMouseButton.UseVisualStyleBackColor = true;
            // 
            // ScrollWheelButton
            // 
            this.ScrollWheelButton.AutoSize = true;
            this.ScrollWheelButton.Location = new System.Drawing.Point(127, 28);
            this.ScrollWheelButton.Name = "ScrollWheelButton";
            this.ScrollWheelButton.Size = new System.Drawing.Size(82, 17);
            this.ScrollWheelButton.TabIndex = 1;
            this.ScrollWheelButton.TabStop = true;
            this.ScrollWheelButton.Text = "Scroll wheel";
            this.ScrollWheelButton.UseVisualStyleBackColor = true;
            // 
            // LeftMouseButton
            // 
            this.LeftMouseButton.AutoSize = true;
            this.LeftMouseButton.Location = new System.Drawing.Point(6, 28);
            this.LeftMouseButton.Name = "LeftMouseButton";
            this.LeftMouseButton.Size = new System.Drawing.Size(77, 17);
            this.LeftMouseButton.TabIndex = 0;
            this.LeftMouseButton.TabStop = true;
            this.LeftMouseButton.Text = "Left mouse";
            this.LeftMouseButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CurrentPositionButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сursor position";
            // 
            // CurrentPositionButton
            // 
            this.CurrentPositionButton.AutoSize = true;
            this.CurrentPositionButton.Location = new System.Drawing.Point(6, 28);
            this.CurrentPositionButton.Name = "CurrentPositionButton";
            this.CurrentPositionButton.Size = new System.Drawing.Size(98, 17);
            this.CurrentPositionButton.TabIndex = 0;
            this.CurrentPositionButton.TabStop = true;
            this.CurrentPositionButton.Text = "Current position";
            this.CurrentPositionButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(173, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select position of cursor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Autoclicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RightMouseButton;
        private System.Windows.Forms.RadioButton ScrollWheelButton;
        private System.Windows.Forms.RadioButton LeftMouseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CurrentPositionButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

