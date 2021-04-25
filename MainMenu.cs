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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //Кнопка Добавить нового пользователя//
        private void NewUserButton_Click(object sender, EventArgs e)
        {
            AddNewUser win = new AddNewUser();
            win.Show();
            this.Hide();
        }
        //Кнопка Обновить список//
        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "select Balloons.Id_Balloons, Balloons.NameBalloons, Price.NamePrice, Phone.NamePhone from Balloons join Price on Balloons.id_Price = Price.Id_Price join Phone on Balloons.id_Phone = Phone.Id_Phone ORDER BY Id_Balloons ASC;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);
            }
        }
        //Кнопка Добавить новую запись//
        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            AddNewRecord win = new AddNewRecord();
            win.Show();
            this.Hide();
        }
        //Кнопка Удалить запись//
        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (DeleteNumber.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                string query = "delete from Balloons where Id_Balloons = '" + DeleteNumber.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Запись удалена");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Кнопка Поиск по номеру//
        private void FindRecord_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "select Balloons.Id_Balloons, Balloons.NameBalloons,Price.NamePrice,Phone.NamePhone from Balloons join Price ON Balloons.id_Price = Price.Id_Price join Phone on Balloons.id_Phone = Phone.Id_Phone where Id_Balloons = '" + FindNumber.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
