using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Formochka
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Закрытие окна
        private void closeButton1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Анимация кнопки закрытия окна
        private void closeButton1_MouseEnter(object sender, EventArgs e)
        {
            closeButton1.ForeColor = Color.FromArgb(84, 0, 190);
        }

        private void closeButton1_MouseLeave(object sender, EventArgs e)
        {
            closeButton1.ForeColor = Color.White;
        }

        // Передвиежние окна по экрану
        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // Создаение Свойств и передача им значений из Form1
        public string Levels
        {
            get { return Form1.levels; }
            set { Form1.levels = value; }
        }

        public string Language
        {
            get { return Form1.language; }
            set { Form1.language = value; }
        }

        public string Type
        {
            get { return Form1.type; }
            set { Form1.type = value; }
        }

        // Вспомагательные переменные
        bool flag = true;
        int lenght;
        string str_showedText;
        string str_textBox;


        // Механизм динамической проверки вводимого текста
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lenght = textBox1.Text.Length;

            // Замена Enter-ов на произвольный символ для дальнейшего сравнения
            str_showedText = showedText.Text.Replace("\n", "ч");
            str_textBox = textBox1.Text.Replace("\r\n", "ч");

            // Механизм проверка того, что пользователь ввел весь текст правильно
            showedText.SelectionStart = showedText.Text.Length - 2;
            showedText.SelectionLength = 1;
            if (showedText.SelectionColor == Color.Gray)
            {
                textBox1.Text = "";
                showedText.ForeColor = Color.White;

                // Генерация и вывод нового текста
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `TXT` FROM `texts` WHERE `language` = @lang AND `level` = @lev AND `Text/Code` = @type", db.getConnection());
                command.Parameters.Add("@lang", MySqlDbType.VarChar).Value = Language;
                command.Parameters.Add("@lev", MySqlDbType.VarChar).Value = Levels;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = Type;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                Random rnd_rows = new Random();
                showedText.Text = table.Rows[rnd_rows.Next(table.Rows.Count - 1)].Field<string>("TXT");
            }

            lenght = str_textBox.Length;

            // Механизм проверки введенного символа
            if ((lenght != 0) && (lenght <= showedText.Text.Length))
            {
                if (str_showedText.Remove(lenght) != str_textBox.Remove(lenght))
                {
                    showedText.ForeColor = Color.Yellow;
                    if (flag == true)
                    {
                        showedText.SelectionStart = 0;
                        showedText.SelectionLength = lenght - 1;
                        showedText.SelectionColor = Color.Gray;
                        flag = false;
                    }
                }
                else
                {
                    flag = true;
                    showedText.ForeColor = Color.White;
                    showedText.SelectionStart = 0;
                    showedText.SelectionLength = lenght;
                    showedText.SelectionColor = Color.Gray;
                }
            }
        }

        // Открытие и закрытие вспомогательной клавиатуры
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
            this.Height = 541;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
            this.Height = 693;
        }
    }
}
