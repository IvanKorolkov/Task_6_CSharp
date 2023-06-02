namespace Task6
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
            this.dllButton = new System.Windows.Forms.Button();
            this.figureButton = new System.Windows.Forms.Button();
            this.methodButton = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dllButton
            // 
            this.dllButton.Location = new System.Drawing.Point(105, 22);
            this.dllButton.Name = "dllButton";
            this.dllButton.Size = new System.Drawing.Size(136, 44);
            this.dllButton.TabIndex = 0;
            this.dllButton.Text = "Выбрать библиотеку";
            this.dllButton.UseVisualStyleBackColor = true;
            this.dllButton.Click += new System.EventHandler(this.OpenLibrary);
            // 
            // figureButton
            // 
            this.figureButton.Location = new System.Drawing.Point(199, 83);
            this.figureButton.Name = "figureButton";
            this.figureButton.Size = new System.Drawing.Size(136, 60);
            this.figureButton.TabIndex = 1;
            this.figureButton.Text = "Выбрать геометрическую фигуру";
            this.figureButton.UseVisualStyleBackColor = true;
            this.figureButton.Visible = false;
            this.figureButton.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // methodButton
            // 
            this.methodButton.Location = new System.Drawing.Point(199, 146);
            this.methodButton.Name = "methodButton";
            this.methodButton.Size = new System.Drawing.Size(136, 42);
            this.methodButton.TabIndex = 2;
            this.methodButton.Text = "Выбрать метод";
            this.methodButton.UseVisualStyleBackColor = true;
            this.methodButton.Visible = false;
            this.methodButton.Click += new System.EventHandler(this.methodButton_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(25, 93);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(136, 23);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.Visible = false;
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(25, 157);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(136, 23);
            this.methodComboBox.TabIndex = 4;
            this.methodComboBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 202);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.methodButton);
            this.Controls.Add(this.figureButton);
            this.Controls.Add(this.dllButton);
            this.Name = "Form1";
            this.Text = "Task6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dllButton;
        private System.Windows.Forms.Button figureButton;
        private System.Windows.Forms.Button methodButton;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
    }
}

