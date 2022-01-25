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
            this.MouseGroupbox = new System.Windows.Forms.GroupBox();
            this.RightMouseButton = new System.Windows.Forms.RadioButton();
            this.ScrollWheelButton = new System.Windows.Forms.RadioButton();
            this.LeftMouseButton = new System.Windows.Forms.RadioButton();
            this.CurrentPosGroupbox = new System.Windows.Forms.GroupBox();
            this.CurrentPositionButton = new System.Windows.Forms.RadioButton();
            this.SelectPosCursorGroupbox = new System.Windows.Forms.GroupBox();
            this.SelectByClickButton = new System.Windows.Forms.RadioButton();
            this.yTextbox = new System.Windows.Forms.TextBox();
            this.xTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeGroupbox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mstextbox = new System.Windows.Forms.TextBox();
            this.Sectextbox = new System.Windows.Forms.TextBox();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.HourTextbox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.MouseGroupbox.SuspendLayout();
            this.CurrentPosGroupbox.SuspendLayout();
            this.SelectPosCursorGroupbox.SuspendLayout();
            this.TimeGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MouseGroupbox
            // 
            this.MouseGroupbox.Controls.Add(this.RightMouseButton);
            this.MouseGroupbox.Controls.Add(this.ScrollWheelButton);
            this.MouseGroupbox.Controls.Add(this.LeftMouseButton);
            this.MouseGroupbox.Location = new System.Drawing.Point(12, 12);
            this.MouseGroupbox.Name = "MouseGroupbox";
            this.MouseGroupbox.Size = new System.Drawing.Size(361, 71);
            this.MouseGroupbox.TabIndex = 2;
            this.MouseGroupbox.TabStop = false;
            this.MouseGroupbox.Text = "Mouse";
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
            // CurrentPosGroupbox
            // 
            this.CurrentPosGroupbox.Controls.Add(this.CurrentPositionButton);
            this.CurrentPosGroupbox.Location = new System.Drawing.Point(12, 98);
            this.CurrentPosGroupbox.Name = "CurrentPosGroupbox";
            this.CurrentPosGroupbox.Size = new System.Drawing.Size(143, 72);
            this.CurrentPosGroupbox.TabIndex = 3;
            this.CurrentPosGroupbox.TabStop = false;
            this.CurrentPosGroupbox.Text = "Сursor position";
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
            // SelectPosCursorGroupbox
            // 
            this.SelectPosCursorGroupbox.Controls.Add(this.SelectByClickButton);
            this.SelectPosCursorGroupbox.Controls.Add(this.yTextbox);
            this.SelectPosCursorGroupbox.Controls.Add(this.xTextbox);
            this.SelectPosCursorGroupbox.Controls.Add(this.label2);
            this.SelectPosCursorGroupbox.Controls.Add(this.label1);
            this.SelectPosCursorGroupbox.Location = new System.Drawing.Point(173, 98);
            this.SelectPosCursorGroupbox.Name = "SelectPosCursorGroupbox";
            this.SelectPosCursorGroupbox.Size = new System.Drawing.Size(200, 81);
            this.SelectPosCursorGroupbox.TabIndex = 3;
            this.SelectPosCursorGroupbox.TabStop = false;
            this.SelectPosCursorGroupbox.Text = "Select position of cursor";
            // 
            // SelectByClickButton
            // 
            this.SelectByClickButton.AutoSize = true;
            this.SelectByClickButton.Location = new System.Drawing.Point(47, 19);
            this.SelectByClickButton.Name = "SelectByClickButton";
            this.SelectByClickButton.Size = new System.Drawing.Size(94, 17);
            this.SelectByClickButton.TabIndex = 7;
            this.SelectByClickButton.TabStop = true;
            this.SelectByClickButton.Text = "Select by click";
            this.SelectByClickButton.UseVisualStyleBackColor = true;
            // 
            // yTextbox
            // 
            this.yTextbox.Location = new System.Drawing.Point(106, 52);
            this.yTextbox.Name = "yTextbox";
            this.yTextbox.Size = new System.Drawing.Size(50, 20);
            this.yTextbox.TabIndex = 6;
            // 
            // xTextbox
            // 
            this.xTextbox.Location = new System.Drawing.Point(31, 52);
            this.xTextbox.Name = "xTextbox";
            this.xTextbox.Size = new System.Drawing.Size(50, 20);
            this.xTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // TimeGroupbox
            // 
            this.TimeGroupbox.Controls.Add(this.label6);
            this.TimeGroupbox.Controls.Add(this.label5);
            this.TimeGroupbox.Controls.Add(this.label4);
            this.TimeGroupbox.Controls.Add(this.label3);
            this.TimeGroupbox.Controls.Add(this.Mstextbox);
            this.TimeGroupbox.Controls.Add(this.Sectextbox);
            this.TimeGroupbox.Controls.Add(this.MinTextbox);
            this.TimeGroupbox.Controls.Add(this.HourTextbox);
            this.TimeGroupbox.Location = new System.Drawing.Point(12, 185);
            this.TimeGroupbox.Name = "TimeGroupbox";
            this.TimeGroupbox.Size = new System.Drawing.Size(361, 100);
            this.TimeGroupbox.TabIndex = 4;
            this.TimeGroupbox.TabStop = false;
            this.TimeGroupbox.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hour";
            // 
            // Mstextbox
            // 
            this.Mstextbox.Location = new System.Drawing.Point(308, 45);
            this.Mstextbox.Name = "Mstextbox";
            this.Mstextbox.Size = new System.Drawing.Size(47, 20);
            this.Mstextbox.TabIndex = 3;
            // 
            // Sectextbox
            // 
            this.Sectextbox.Location = new System.Drawing.Point(218, 45);
            this.Sectextbox.Name = "Sectextbox";
            this.Sectextbox.Size = new System.Drawing.Size(47, 20);
            this.Sectextbox.TabIndex = 2;
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(127, 45);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(47, 20);
            this.MinTextbox.TabIndex = 1;
            // 
            // HourTextbox
            // 
            this.HourTextbox.Location = new System.Drawing.Point(42, 45);
            this.HourTextbox.Name = "HourTextbox";
            this.HourTextbox.Size = new System.Drawing.Size(47, 20);
            this.HourTextbox.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(146, 312);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 347);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeGroupbox);
            this.Controls.Add(this.SelectPosCursorGroupbox);
            this.Controls.Add(this.CurrentPosGroupbox);
            this.Controls.Add(this.MouseGroupbox);
            this.Name = "Form1";
            this.Text = "Autoclicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseGroupbox.ResumeLayout(false);
            this.MouseGroupbox.PerformLayout();
            this.CurrentPosGroupbox.ResumeLayout(false);
            this.CurrentPosGroupbox.PerformLayout();
            this.SelectPosCursorGroupbox.ResumeLayout(false);
            this.SelectPosCursorGroupbox.PerformLayout();
            this.TimeGroupbox.ResumeLayout(false);
            this.TimeGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MouseGroupbox;
        private System.Windows.Forms.RadioButton RightMouseButton;
        private System.Windows.Forms.RadioButton ScrollWheelButton;
        private System.Windows.Forms.RadioButton LeftMouseButton;
        private System.Windows.Forms.GroupBox CurrentPosGroupbox;
        private System.Windows.Forms.RadioButton CurrentPositionButton;
        private System.Windows.Forms.GroupBox SelectPosCursorGroupbox;
        private System.Windows.Forms.TextBox xTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yTextbox;
        private System.Windows.Forms.GroupBox TimeGroupbox;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.TextBox HourTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Mstextbox;
        private System.Windows.Forms.TextBox Sectextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RadioButton SelectByClickButton;
    }
}

