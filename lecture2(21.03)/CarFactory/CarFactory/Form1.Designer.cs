namespace CarFactory
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
            title = new Label();
            confirmButton = new Button();
            comboBoxEngines = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxTransmission = new ComboBox();
            label3 = new Label();
            comboBoxBodyShape = new ComboBox();
            comboBoxColor = new ComboBox();
            comboBoxModel = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxSteeringPosition = new ComboBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F);
            title.Location = new Point(197, 9);
            title.Name = "title";
            title.Size = new Size(412, 35);
            title.TabIndex = 0;
            title.Text = "Выберите конфигурацию машины";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(197, 403);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(451, 35);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Подтвердить";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += button1_Click;
            // 
            // comboBoxEngines
            // 
            comboBoxEngines.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEngines.FormattingEnabled = true;
            comboBoxEngines.Location = new Point(44, 101);
            comboBoxEngines.Name = "comboBoxEngines";
            comboBoxEngines.Size = new Size(151, 28);
            comboBoxEngines.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 66);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Тип двигателя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 66);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 4;
            label2.Text = "Тип коробки передач";
            // 
            // comboBoxTransmission
            // 
            comboBoxTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransmission.FormattingEnabled = true;
            comboBoxTransmission.Location = new Point(332, 101);
            comboBoxTransmission.Name = "comboBoxTransmission";
            comboBoxTransmission.Size = new Size(151, 28);
            comboBoxTransmission.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(605, 66);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 6;
            label3.Text = "Тип формы кузова";
            // 
            // comboBoxBodyShape
            // 
            comboBoxBodyShape.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBodyShape.FormattingEnabled = true;
            comboBoxBodyShape.Location = new Point(605, 101);
            comboBoxBodyShape.Name = "comboBoxBodyShape";
            comboBoxBodyShape.Size = new Size(151, 28);
            comboBoxBodyShape.TabIndex = 7;
            // 
            // comboBoxColor
            // 
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(44, 317);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(151, 28);
            comboBoxColor.TabIndex = 8;
            // 
            // comboBoxModel
            // 
            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(332, 317);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(151, 28);
            comboBoxModel.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 284);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 10;
            label4.Text = "Цвет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 284);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "Модель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 284);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 12;
            label6.Text = "Положение руля";
            // 
            // comboBoxSteeringPosition
            // 
            comboBoxSteeringPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSteeringPosition.FormattingEnabled = true;
            comboBoxSteeringPosition.Location = new Point(605, 317);
            comboBoxSteeringPosition.Name = "comboBoxSteeringPosition";
            comboBoxSteeringPosition.Size = new Size(151, 28);
            comboBoxSteeringPosition.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxSteeringPosition);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxModel);
            Controls.Add(comboBoxColor);
            Controls.Add(comboBoxBodyShape);
            Controls.Add(label3);
            Controls.Add(comboBoxTransmission);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxEngines);
            Controls.Add(confirmButton);
            Controls.Add(title);
            Name = "Form1";
            Text = "CarFactory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button confirmButton;
        private ComboBox comboBoxEngines;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxTransmission;
        private Label label3;
        private ComboBox comboBoxBodyShape;
        private ComboBox comboBoxColor;
        private ComboBox comboBoxModel;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxSteeringPosition;
    }
}
