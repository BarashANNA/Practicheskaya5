using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FlyBallon
{
    public partial class AddNewRecord : Form
    {
        public AddNewRecord()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Кнопка Добавить//
        private void AddNew_Click(object sender, EventArgs e)
        {
            if (NewBalloon.Text == "" || NewPrice.Text == "" || NewPhone.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                string query = "INSERT INTO Balloons (NameBalloons,id_Price,id_Phone) values('" + NewBalloon.Text + "','" + NewPrice.Text + "','" + NewPhone.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Запись добавлена");
                    this.Close();
                    MainMenu win = new MainMenu();
                    win.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
