using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_calculator
{
    public partial class windowCalculator : Form
    {
        public bool is_male = true;
        bool is_formul_Hurris = false;
        bool is_formul_Mulffin = false;

        int numberAge = 0;
        int numberWeight = 0;
        int numberHeight = 0;

        double resultHarris = 0;
        double resultMulffin = 0;

        int intResultHarris = 0;
        int intResultMulffin = 0;

        double bmrHarris = 0;
        double bmrMulffin = 0;

        double amr = 0;

        double maleHarris = 0;
        double weightHarris = 0;
        double heightHarris = 0;
        double ageHarris = 0;
        int maleMulffin = 0;

        const double ACTIVITY0 = 1.2;
        const double ACTIVITY1 = 1.375;
        const double ACTIVITY2 = 1.4625;
        const double ACTIVITY3 = 1.55;
        const double ACTIVITY4 = 1.6375;
        const double ACTIVITY5 = 1.725;
        const double ACTIVITY6 = 1.9;
        const double HEIGHTMULFFIN = 6.25;

        const int AGEMULFFIN = 5;
        const int WEIGHTMULFFIN = 10;

        public windowCalculator()
        {
            InitializeComponent();

            comboBoxActivity.SelectedIndex = 0;

            ToolTip toolTipAge = new ToolTip();
            ToolTip toolTipWeight = new ToolTip();
            ToolTip toolTipHeight = new ToolTip();
            ToolTip toolTipActivity = new ToolTip();
            ToolTip toolTipHurris = new ToolTip(); 
            ToolTip toolTipMalffin = new ToolTip();

            toolTipAge.InitialDelay = 500;
            toolTipAge.ReshowDelay = 100;
            toolTipAge.AutoPopDelay = 5000;

            toolTipWeight.InitialDelay = 500;
            toolTipWeight.ReshowDelay = 100;
            toolTipWeight.AutoPopDelay = 5000;

            toolTipHeight.InitialDelay = 500;
            toolTipHeight.ReshowDelay = 100;
            toolTipHeight.AutoPopDelay = 5000;

            toolTipActivity.InitialDelay = 500;
            toolTipActivity.ReshowDelay = 100;
            toolTipActivity.AutoPopDelay = 5000;

            toolTipHurris.InitialDelay = 500;
            toolTipHurris.ReshowDelay = 100;
            toolTipHurris.AutoPopDelay = 16000;

            toolTipMalffin.InitialDelay = 500;
            toolTipMalffin.ReshowDelay = 100;
            toolTipMalffin.AutoPopDelay = 12000;

            toolTipAge.SetToolTip(this.textBoxAge, "Введите ваш возраст целым числом");

            toolTipWeight.SetToolTip(this.textBoxWeight, "Введите ваш вес целым числом");

            toolTipHeight.SetToolTip(this.textBoxHeight, "Введите ваш рост целым числом");

            toolTipActivity.SetToolTip(this.comboBoxActivity, "Выберите один из представленных вариантов");

            toolTipHurris.SetToolTip(this.checkBoxHurris, "Авторы формулы — американский химик, физиолог и диетолог Фрэнсис Гано Бенедикт, а также ботаник Джеймс Артур Харрис." +
                                    $"{Environment.NewLine}Формула расчета основного обмена Харриса-Бенедикта была выведена в 1919 году. Была пересмотрена в 1984 году и стала" +
                                    $"{Environment.NewLine}более точной. Использовалась до 1990 года.");

            toolTipMalffin.SetToolTip(this.checkBoxMulffin, "Современная формула расчета основного обмена веществ Миффлина-Сент-Джора. Уравнение Миффлина - Сент-Джора" +
                                      $"{Environment.NewLine}оказалось более точным, чем пересмотренное уравнение Харриса - Бенедикта.");

            button.Enabled = false;
        }

        private void calculate_bmr()
        {
            if (is_formul_Hurris)
            {
                bmrHarris = maleHarris + weightHarris * numberWeight + heightHarris * numberHeight - ageHarris * numberAge;
            }

             if (is_formul_Mulffin)
            {
                bmrMulffin = WEIGHTMULFFIN * numberWeight + HEIGHTMULFFIN * numberHeight - AGEMULFFIN * numberAge + maleMulffin;
            }

            else if (is_formul_Hurris == false && is_formul_Mulffin == false)
            {
                textBoxResalt.AppendText($"Выберите формулу.{Environment.NewLine}");
                Console.WriteLine($"Попытка оставить checkBox без значения.{Environment.NewLine}");
            }
        }

        private void calculate_amr()
        {

            switch (comboBoxActivity.SelectedIndex)
            {
                case 0:
                    amr = ACTIVITY0;
                    break;
                case 1:
                    amr = ACTIVITY1;
                    break;
                case 2:
                    amr = ACTIVITY2;
                    break;
                case 3:
                    amr = ACTIVITY3;
                    break;
                case 4:
                    amr = ACTIVITY4;
                    break;
                case 5:
                    amr = ACTIVITY5;
                    break;
                case 6:
                    amr = ACTIVITY6;
                    break;
                default:
                    textBoxResalt.AppendText($"Выберите значение физической активности.{Environment.NewLine}");
                    Console.WriteLine($"Попытка оставить comboBox без значения.{Environment.NewLine}");
                    break;
            }

        }

        private void calculate_result_Harris()
        {
            if (is_formul_Hurris)
            {
                resultHarris = bmrHarris * amr;
                intResultHarris = Convert.ToInt32(resultHarris);
                textBoxResalt.AppendText($"Суточная норма потребления калорий для поддержания текущего веса по формуле Харриса-Бенедикта: {Convert.ToString(intResultHarris)}{Environment.NewLine}{Environment.NewLine}");
            }
        }

        private void calculate_result_Mulffin()
        {
            if (is_formul_Mulffin)
            {
                resultMulffin = bmrMulffin * amr;
                intResultMulffin = Convert.ToInt32(resultMulffin);
                textBoxResalt.AppendText($"Суточная норма потребления калорий для поддержания текущего веса по формуле Миффлина-Сан Жеора: {Convert.ToString(intResultMulffin)}{Environment.NewLine}{Environment.NewLine}");
            }
        }

        private void offButton()
        {
            if (textBoxAge.Text.Length > 0
               && textBoxWeight.Text.Length > 0
               && textBoxHeight.Text.Length > 0)
            {
                button.Enabled = true;
            }

            else
            {
                button.Enabled = false;
            }
            return;
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxAge))
                        textBoxWeight.Focus();
                }
                return;
            }
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxWeight))
                        textBoxHeight.Focus();
                }
                return;
            }
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            is_male = true;
            return;
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            is_male = false;
            return;
        }

        private void groupBoxSex_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxHeight))
                        comboBoxActivity.Focus();
                }
                return;
            }
        }



        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            offButton();
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            offButton();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            offButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void windowCalculator_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void checkBoxHurris_CheckedChanged(object sender, EventArgs e)
        {           
                is_formul_Hurris = checkBoxHurris.Checked;
        }

        private void checkBoxMulffin_CheckedChanged(object sender, EventArgs e)
        {
                is_formul_Mulffin = checkBoxMulffin.Checked;
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBoxResalt.Clear();

            string textAge = textBoxAge.Text;
            string textWeight = textBoxWeight.Text;
            string textHeight = textBoxHeight.Text;            

            if (is_male)
            {
                maleHarris = 88.362;
                weightHarris = 13.397;
                heightHarris = 4.799;
                ageHarris = 5.677;
                maleMulffin = 5;
            }
            else
            {
                maleHarris = 447.593;
                weightHarris = 9.247;
                heightHarris = 3.098;
                ageHarris = 4.33;
                maleMulffin = -161;
            }

            try
            {
                numberAge = Convert.ToInt32(textAge);
                numberWeight = Convert.ToInt32(textWeight);
                numberHeight = Convert.ToInt32(textHeight);
                                                                 
                if (numberAge <= 0 || numberWeight <= 0 || numberHeight<= 0)
                {
                    textBoxResalt.AppendText($"Вы ввели недопустимый(ые) символ(ы).{Environment.NewLine}");
                    Console.WriteLine($"Попытка ввести отрицательное число или 0.{Environment.NewLine}");
                }
                else
                {
                    calculate_bmr();
                    calculate_amr();

                    calculate_result_Harris();
                    calculate_result_Mulffin();
                }
               
            }
            catch (Exception error)
            {
                textBoxResalt.AppendText($"Вы ввели недопустимый(ые) символ(ы).{Environment.NewLine}");
                Console.WriteLine($"{error} Попытка ввести букву или другой символ не являющийся цифрой.{Environment.NewLine}");
            }
        }

        private void CheckBoxMan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxWoman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void windowCalculator_Load(object sender, EventArgs e)
        {

        }

        private void labelSm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxResalt.Clear();
        }
    }
}
