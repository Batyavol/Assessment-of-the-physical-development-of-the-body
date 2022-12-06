using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PE.Main;

namespace PE
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            this.Text = "Оценка физического развития и функционального состояния организма человека";
            float BWI = MyGlobals.weight/ ( MyGlobals.heigh - 110);
            if (BWI < 0.8)
                label2.Text = "Весоростовой индекс Брока = " + Math.Round(BWI, 2) + ".\nВы худощавый.";
            if (BWI >= 0.8 && BWI <= 0.9)
                label2.Text = "Весоростовой индекс Брока = " + Math.Round(BWI, 2) + ".\nВы стройный.";
            if (BWI > 0.9 && BWI <= 1)
                label2.Text = "Весоростовой индекс Брока = " + Math.Round(BWI, 2) + ".\nВы средний.";
            if (BWI > 1 && BWI <= 1.1)
                label2.Text = "Весоростовой индекс Брока = " + Math.Round(BWI, 2) + ".\nУ вас угроза тучности.";
            if (BWI > 1.1)
                label2.Text = "Весоростовой индекс Брока = " + Math.Round(BWI, 2) + ".\nУ вас ожирение.";
            

            float BMI = MyGlobals.weight / ((MyGlobals.heigh/100) * (MyGlobals.heigh/100));
            if (BMI < 20)
                label3.Text = "Индекс массы тела = " + Math.Round(BMI, 2) + ".\nУ вас недостаток массы тела.";
            if (BMI >= 20 && BMI <= 25)
                label3.Text = "Индекс массы тела = " + Math.Round(BMI, 2) + ".\nУ вас нормальный вес.";
            if (BMI > 25 && BMI <= 30)
                label3.Text = "Индекс массы тела = " + Math.Round(BMI, 2) + ".\nУ вас избыточный вес.";
            if (BMI > 30)
                label3.Text = "Индекс массы тела = " + Math.Round(BMI, 2) + ".\nУ вас ожирение.";

            float PI = MyGlobals.heigh - (MyGlobals.weight + MyGlobals.CG);
            if (PI < 11)
                label4.Text = "Показатель Пинье = " + PI + ".\nУ вас крепкое телосложение.";
            if (PI >= 11 && PI <= 20)
                label4.Text = "Показатель Пинье = " + PI + ".\nУ вас хорошее телосложение.";
            if (PI > 20 && PI <= 25)
                label4.Text = "Показатель Пинье = " + PI + ".\nУ вас среднее телосложение.";
            if (PI > 25 && PI <= 35)
                label4.Text = "Показатель Пинье = " + PI + ".\nУ вас слабое телосложение.";
            if (PI > 35)
                label4.Text = "Показатель Пинье = " + PI + ".\nУ вас очень слабое телосложение.";

            double UFC = (700 - (3 * MyGlobals.Heartrate) - (2.5 * MyGlobals.Bloodp) - (2.7 * MyGlobals.Age) + (0.28 * MyGlobals.weight)) / (350 - (2.6 * MyGlobals.Age) + (0.21 * MyGlobals.heigh));
            if (MyGlobals.Sex == 1)
            {
                if (UFC <= 0.375)
                    label5.Text = "  " + Math.Round(UFC, 3) + ".\nУФС низкий.";
                if (UFC > 0.375 && UFC <= 0.525)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС ниже среднего.";
                if (UFC > 0.525 && UFC <= 0.675)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС средний.";
                if (UFC > 0.675 && UFC <= 0.825)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС выше среднего.";
                if (UFC > 0.825)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС высокий.";
            }
            if (MyGlobals.Sex == 0)
            {
                if (UFC <= 0.260)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС низкий.";
                if (UFC > 0.260 && UFC <= 0.365)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС ниже среднего.";
                if (UFC > 0.365 && UFC <= 0.475)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС средний.";
                if (UFC > 0.475 && UFC <= 0.575)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС выше среднего.";
                if (UFC > 0.575)
                    label5.Text = "Уровень физического состояния (УФС) = " + Math.Round(UFC, 3) + ".\nУФС высокий.";
            }

            double Doun = (220 - MyGlobals.Age - MyGlobals.Heartrate) * 0.8 + MyGlobals.Heartrate;
            double Up = (220 - MyGlobals.Age - MyGlobals.Heartrate) * 0.5 + MyGlobals.Heartrate;
            label6.Text = "Нижняя граница пульсового коридора = " + Doun;
            label7.Text = "Верхняя граница пульсового коридора = " + Up;

            if (MyGlobals.Heartratere <= 60)
                label8.Text = "У вас отличная приспособляемость к физической нагрузке";
            if (MyGlobals.Heartratere > 60 && MyGlobals.Heartratere <= 120)
                label8.Text = "У вас хорошая приспособляемость к физической нагрузке";
            if (MyGlobals.Heartratere > 120 && MyGlobals.Heartratere <= 180)
                label8.Text = "У вас удовлетворительная приспособляемость к физической нагрузке";
            if (MyGlobals.Heartratere > 180)
                label8.Text = "У вас низкая приспособляемость к физической нагрузке";
        }

    }
}
