using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PE
{
    public partial class Main : Form
    {
        public static class MyGlobals
        {
            public static float heigh;
            public static float weight;
            public static float CG;
            public static float Bloodp;
            public static float Heartrate;
            public static float Heartratere;
            public static float Age;
            public static float Sex;
        }
        public Main()
        {
            InitializeComponent();
            this.Text = "Оценка физического развития и функционального состояния организма человека";
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            age_Label.BackColor = Color.Transparent;
            Sex_Label.BackColor = Color.Transparent;
            M.BackColor = Color.Transparent;
            W.BackColor = Color.Transparent;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            System.Environment.Exit(-1);
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e) //Добавить к дочерней форме
        {
            System.Environment.Exit(0);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ( Heigh_TB.Text == String.Empty || Weight_TB.Text == String.Empty || CG_TB.Text == String.Empty || Bloodp_TB.Text == String.Empty || Heartrate_TB.Text == String.Empty || Heartratere_TB.Text == String.Empty || Age_TB.Text == String.Empty || (M.Checked == false && W.Checked == false))
                MessageBox.Show("Вы ввели не все параметры");
            else if (M.Checked == true && W.Checked == true)
                MessageBox.Show("Вы не можете указать два пола, выберите один из них");
            else
            {
                MyGlobals.heigh = Convert.ToSingle(Heigh_TB.Text);
                MyGlobals.weight = Convert.ToSingle(Weight_TB.Text);
                MyGlobals.CG = Convert.ToSingle(CG_TB.Text);
                MyGlobals.Bloodp = Convert.ToSingle(Bloodp_TB.Text);
                MyGlobals.Heartrate = Convert.ToSingle(Heartrate_TB.Text);
                MyGlobals.Heartratere = Convert.ToSingle(Heartratere_TB.Text);
                MyGlobals.Age = Convert.ToSingle(Age_TB.Text);
                if (M.Checked == true)
                    MyGlobals.Sex = 1;
                if (W.Checked == true)
                    MyGlobals.Sex = 0;
                Result main = new Result();
                main.Show();
                main.Location = this.Location;
                this.Hide();
            }
        }

        private void clarification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проба проводиться следующим образом, измеряется ЧСС в покое \nна лучевой, сонной или височной артерии за 10 сек в положении сидя.\nЧеловек встает: ноги врозь (на ширине плеч), стопы параллельно и делают 20 приседаний за 30 секунд, не отрывая пяток от пола, не соединяя коленей, таз опускается до уровня коленного сустава, угол в коленном суставе должен составлять 90 градусов, руки вперед. Выпрямляясь руки вниз.Приседания выполняются в темпе: 1приседание за 1- 1,5 секунды.Сразу после приседаний испытуемый садится, включают секундомер и в течение первых 10 сек. подсчитывают пульс сидя, после физической нагрузки.Секундомер не выключаем и, начиная с 20 по 30 секунды, измеряем пульс за 10 секунд, если цифра при подсчете пульса стала такой же, как ЧСС в покое, то в протокол заполняем восстановление - 30 секунд.Следующее измерения проводим с 50 до 60 секунды (если пульс восстановился, записываем - 60 секунд восстановления). Если пульс не восстанавливается, выполняем измерение в 1,50 секунд до 2 минут (120 секунд восстановления). И последнее измерение в 2,50 до 3 минут (180 секунд восстановления). Если пульс не восстановился за 3 минуты, то в протокол ставится знак >3мин.");
        }

        private void Heigh_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
