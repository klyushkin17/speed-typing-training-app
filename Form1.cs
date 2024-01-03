using MySql.Data.MySqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Formochka;

namespace Formochka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        // Передвижение окна по экрану
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

        // Закрытие приложения
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Анимация для кнопки закрытия приложения
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(84, 0, 190);

        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        // Переменные (характеристики текста)
        internal static string levels;
        internal static string language;
        internal static string type;

        // Свойства (характеристики текста)
        public string Levels
        {
            get { return levels; }
            set { levels = value; } 
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // Нажатие на кнопку "Начать"
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            TextCheck text = new TextCheck();

            // Проверка сложности текса
            Levels = text.CheckLevels(boxLevel.Text);

            // Проверка языка текста
            language = boxLanguage.Text;

            // Если язык не выбран
            Language = text.CheckLanguage(language);

            // Проверка типа текста
            if (types.Checked == true)
            {
                Type = "Code";
                Language = "None";
                Levels = "None";
            }
            else
            {
                Type = "Text";
            }

            // Получение текста из базы данных
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `TXT` FROM `texts` WHERE `language` = @lang AND `level` = @lev AND `Text/Code` = @type" , db.getConnection());
            command.Parameters.Add("@lang", MySqlDbType.VarChar).Value = Language;
            command.Parameters.Add("@lev", MySqlDbType.VarChar).Value = Levels;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = Type;

            // Заполнение типа Table текстами
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Рандомный выбор текста из Table
            Random rnd_rows = new Random();
            form.showedText.Text = table.Rows[rnd_rows.Next(table.Rows.Count - 1)].Field<string>("TXT");
            this.Hide();
        }

        // Исчезновение варианта выбора языка и сложности при нажатии на "Код"
        private void types_CheckedChanged(object sender, EventArgs e)
        {
            if (types.Checked == true)
            {
                boxLanguage.Visible = false;
                boxLevel.Visible = false;
            }
            else 
            {
                boxLanguage.Visible = true;
                boxLevel.Visible = true;
            }
        }
    }
}