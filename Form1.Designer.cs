
namespace Calories_calculator
{
    partial class windowCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowCalculator));
            this.checkBoxHurris = new System.Windows.Forms.CheckBox();
            this.checkBoxMulffin = new System.Windows.Forms.CheckBox();
            this.comboBoxActivity = new System.Windows.Forms.ComboBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelActivity = new System.Windows.Forms.Label();
            this.labelFormuls = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.textBoxResalt = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxHurris
            // 
            this.checkBoxHurris.AutoSize = true;
            this.checkBoxHurris.Location = new System.Drawing.Point(220, 267);
            this.checkBoxHurris.Name = "checkBoxHurris";
            this.checkBoxHurris.Size = new System.Drawing.Size(132, 17);
            this.checkBoxHurris.TabIndex = 6;
            this.checkBoxHurris.Text = "Харриса - Бенедикта";
            this.checkBoxHurris.UseVisualStyleBackColor = true;
            this.checkBoxHurris.CheckedChanged += new System.EventHandler(this.checkBoxHurris_CheckedChanged);
            // 
            // checkBoxMulffin
            // 
            this.checkBoxMulffin.AutoSize = true;
            this.checkBoxMulffin.Location = new System.Drawing.Point(219, 290);
            this.checkBoxMulffin.Name = "checkBoxMulffin";
            this.checkBoxMulffin.Size = new System.Drawing.Size(152, 17);
            this.checkBoxMulffin.TabIndex = 7;
            this.checkBoxMulffin.Text = "Миффлина - Сент-Джора";
            this.checkBoxMulffin.UseVisualStyleBackColor = true;
            this.checkBoxMulffin.CheckedChanged += new System.EventHandler(this.checkBoxMulffin_CheckedChanged);
            // 
            // comboBoxActivity
            // 
            this.comboBoxActivity.FormattingEnabled = true;
            this.comboBoxActivity.Items.AddRange(new object[] {
            "Минимальные нагрузки (сидячая работа)",
            "Немного дневной активности и легкие упражнения 1-3 раза в неделю",
            "Тренировки 4-5 раз в неделю (или работа средней тяжести)",
            "Интенсивные тренировки 4-5 раз в неделю",
            "Ежедневные тренировки",
            "Ежедневные интенсивные тренировки или тренировки 2 раза в день",
            "Тяжелая физическая работа или интенсивные тренировки 2 раза в день"});
            this.comboBoxActivity.Location = new System.Drawing.Point(358, 219);
            this.comboBoxActivity.Name = "comboBoxActivity";
            this.comboBoxActivity.Size = new System.Drawing.Size(422, 21);
            this.comboBoxActivity.TabIndex = 9;
            this.comboBoxActivity.SelectedIndexChanged += new System.EventHandler(this.comboBoxActivity_SelectedIndexChanged);
            // 
            // labelinfo
            // 
            this.labelinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelinfo.BackColor = System.Drawing.SystemColors.Info;
            this.labelinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo.Location = new System.Drawing.Point(12, 9);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(768, 75);
            this.labelinfo.TabIndex = 10;
            this.labelinfo.Text = resources.GetString("labelinfo.Text");
            this.labelinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(217, 90);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 11;
            this.labelAge.Text = "Возраст:";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(217, 179);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(30, 13);
            this.labelSex.TabIndex = 12;
            this.labelSex.Text = "Пол:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(217, 142);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(49, 13);
            this.labelWeight.TabIndex = 13;
            this.labelWeight.Text = "Вес (кг):";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(218, 116);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 13);
            this.labelHeight.TabIndex = 14;
            this.labelHeight.Text = "Рост (см):";
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Location = new System.Drawing.Point(217, 222);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(135, 13);
            this.labelActivity.TabIndex = 15;
            this.labelActivity.Text = "Физическая активность:";
            // 
            // labelFormuls
            // 
            this.labelFormuls.AutoSize = true;
            this.labelFormuls.Location = new System.Drawing.Point(217, 251);
            this.labelFormuls.Name = "labelFormuls";
            this.labelFormuls.Size = new System.Drawing.Size(58, 13);
            this.labelFormuls.TabIndex = 16;
            this.labelFormuls.Text = "Формула:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(281, 87);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(30, 20);
            this.textBoxAge.TabIndex = 17;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(281, 139);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(30, 20);
            this.textBoxWeight.TabIndex = 18;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(281, 113);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(30, 20);
            this.textBoxHeight.TabIndex = 19;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Calories_calculator.Properties.Resources._231694911;
            this.pictureBox.Location = new System.Drawing.Point(12, 87);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(199, 220);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.Location = new System.Drawing.Point(637, 426);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(143, 58);
            this.button.TabIndex = 0;
            this.button.Text = "Расчитать";
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonWoman);
            this.groupBoxSex.Controls.Add(this.radioButtonMan);
            this.groupBoxSex.Location = new System.Drawing.Point(254, 167);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(174, 33);
            this.groupBoxSex.TabIndex = 21;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Enter += new System.EventHandler(this.groupBoxSex_Enter);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(99, 11);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(72, 17);
            this.radioButtonWoman.TabIndex = 1;
            this.radioButtonWoman.Text = "Женский";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            this.radioButtonWoman.CheckedChanged += new System.EventHandler(this.radioButtonWoman_CheckedChanged);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Checked = true;
            this.radioButtonMan.Location = new System.Drawing.Point(4, 11);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMan.TabIndex = 0;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Мужской";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // textBoxResalt
            // 
            this.textBoxResalt.AccessibleName = "";
            this.textBoxResalt.Location = new System.Drawing.Point(12, 313);
            this.textBoxResalt.Multiline = true;
            this.textBoxResalt.Name = "textBoxResalt";
            this.textBoxResalt.ReadOnly = true;
            this.textBoxResalt.Size = new System.Drawing.Size(768, 107);
            this.textBoxResalt.TabIndex = 22;
            this.textBoxResalt.TextChanged += new System.EventHandler(this.textBoxResalt_TextChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 426);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(81, 36);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Очистить\r\nрезультаты";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // windowCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 496);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.textBoxResalt);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelFormuls);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.comboBoxActivity);
            this.Controls.Add(this.checkBoxMulffin);
            this.Controls.Add(this.checkBoxHurris);
            this.Controls.Add(this.pictureBox);
            this.Name = "windowCalculator";
            this.Text = "Калькулятор калорий (Directed by VLexR)";
            this.Load += new System.EventHandler(this.windowCalculator_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowCalculator_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBoxHurris;
        private System.Windows.Forms.CheckBox checkBoxMulffin;
        private System.Windows.Forms.ComboBox comboBoxActivity;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.Label labelFormuls;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.TextBox textBoxResalt;
        private System.Windows.Forms.Button ClearButton;
    }
}

