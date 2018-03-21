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
using System.Data.SqlClient;

namespace DataBz
{
    public partial class Form1 : Form
    {
        /// строка подключения к БД
        static string conect = "server=localhost; user=root; database=sight; password=root;";
        string sql = null;//cтрока запроса
        MySqlConnection conn = new MySqlConnection(conect);
        public Form1()
        {

            InitializeComponent();
        }
        //загрузка формы
        private async void Form1_Load(object sender, EventArgs e)
        {


            // создаём объект для подключения к БД
            // MySqlConnection conn = new MySqlConnection(conect);
            // устанавливаем соединение с БД
            await conn.OpenAsync();
            // запрос
            sql = "SELECT  * from sights";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = null;
            //вывод в DataGriv БД
            #region
            try
            {
                List<string[]> data = new List<string[]>();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            reader.Close();
            #endregion
            // закрываем соединение с БД
            conn.Close();

        }
        //кнопка INSERT
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            
            {
                if (txtBoxName.Text == String.Empty )
                {
                    MessageBox.Show(
                   "Необходио заполнить поля",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                }
                
                if(txtBoxStree.Text == String.Empty)
                {
                    label9.Text = "Выберте улицу!";
                }

                else
                {

                    await conn.OpenAsync();

                   

                    if (radBtnSig.Checked)
                    {
                       
                        sql = "INSERT INTO sights (Name,  Year, Author, History, Street,Photo) VALUES (@Name, @Year , @Author, @History, @Street,@Photo)";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@Name", txtBoxName.Text);
                        command.Parameters.Add("@Year", MySqlDbType.Year);
                        command.Parameters["@Year"].Value = txtBoxYer.Text;
                        command.Parameters.AddWithValue("@Author", txtBoxAutor.Text);
                        command.Parameters.AddWithValue("@History", txtBoxHis.Text);
                        command.Parameters.AddWithValue("@Photo", txtBoxPhoto.Text);
                        command.Parameters.AddWithValue("@Street", txtBoxStree.Text);
                        
                           
                        

                        command.ExecuteNonQuery();
                    }

                    if (radBtnStreet.Checked)
                    {
                        sql = "INSERT INTO street (Name, idCity) VALUES (@Name, @idCity)";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@Name", txtBoxName.Text);
                        command.Parameters.AddWithValue("@idCity", txtBoxStree.Text);
                        command.ExecuteNonQuery();
                    }

                    if (radBtnCit.Checked)
                    {
                        sql = "INSERT INTO city (Name) VALUES (@Name)";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@Name", txtBoxName.Text);
                        command.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            


        }
        //кнопка Delet
        private async void btnDelet_Click(object sender, EventArgs e)
        {
            if (txtBoxIDDel.Text == String.Empty)
            {
                MessageBox.Show(
               "Необходио заполнить поля",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            
             
            else
            {

                if (radBtnSighDel.Checked)
                {

                    await conn.OpenAsync();
                    sql = "DELETE FROM sights WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add("@ID", MySqlDbType.Int16);
                    command.Parameters["@ID"].Value = Convert.ToInt16(txtBoxIDDel.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                }

                if (radBtnCitDel.Checked)
                {
                    await conn.OpenAsync();
                    sql = "DELETE FROM city WHERE idCity = @ID";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add("@ID", MySqlDbType.Int16);
                    command.Parameters["@ID"].Value = Convert.ToInt16(txtBoxIDDel.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                }

                if (radBtnStreeDel.Checked)
                {
                    await conn.OpenAsync();
                    sql = "DELETE FROM street WHERE idStreet = @ID";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add("@ID", MySqlDbType.Int16);
                    command.Parameters["@ID"].Value = Convert.ToInt16(txtBoxIDDel.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        
    
        }
        //кнопка Update
        private async void btnUpdateIn_Click_1(object sender, EventArgs e)
        {
            if (txtBoxNmaeUp.Text == String.Empty)
            {
                MessageBox.Show(
               "Необходио заполнить поля",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            await conn.OpenAsync();
            if (radBtnSighUpd.Checked)
            {
                sql = "UPDATE sights SET Name = @Name,  Year = @year, Author = @Author, History = @History WHERE ID = @ID";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("ID", txtBoxID.Text);
                //command.Parameters["ID"].Value = Convert.ToInt16(txtBoxID.Text);
                command.Parameters.AddWithValue("Name", txtBoxNmaeUp.Text);
                command.Parameters.Add("Year", MySqlDbType.Year);
                command.Parameters["Year"].Value = txtBoxYearUp.Text;
                command.Parameters.AddWithValue("Author", txtBoxAutUp.Text);
                command.Parameters.AddWithValue("History", txtBoxHisUp.Text);
                command.ExecuteNonQuery();
            }

            if (radBtnCityUpd.Checked)
            {
                sql = "UPDATE city SET Name = @name WHERE idCity = @ID";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("ID", txtBoxID.Text);
                command.Parameters.AddWithValue("Name", txtBoxNmaeUp.Text);
                command.ExecuteNonQuery();

            }

            if (radBtnStreUpd.Checked)
            {
                sql = "UPDATE street SET Name = @name,  City = @City WHERE idStreet = @ID";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("ID", txtBoxID.Text);
                command.Parameters.AddWithValue("Name", txtBoxNmaeUp.Text);
                command.Parameters.AddWithValue("City", txtBoxAutUp.Text);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    
        //выборка update del sel через radBtn
        #region
        private void radBtnStreet_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxStree.Clear();
            label1.Text = "Улица: ";
            label3.Text = "Город: ";          
            txtBoxYer.Text = "Not Found";
            txtBoxHis.Text = "Not Found";
            txtBoxAutor.Text = "Not Found";
            txtBoxPhoto.Text = "Not Found";
            label10.Text = "id Города";
            label2.Text = "  ";
            label4.Text = " ";
            label3.Text = " ";
            label11.Text = " ";
        }

        private void radBtnSig_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxYer.Clear();
            txtBoxHis.Clear();
            txtBoxStree.Clear();
            txtBoxAutor.Clear();
            txtBoxPhoto.Clear();
            label1.Text = "Название памятника:";
            label3.Text = "Автор:";
            label2.Text = "Год";
            label4.Text = "История";
            label10.Text = "id Улицы";
            label11.Text = "Фото";
        }

        private void radBtnCit_CheckedChanged(object sender, EventArgs e)
        {
            
            label1.Text = "Город:";
            label3.Text = " ";
            label2.Text = " ";
            label4.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            txtBoxAutor.Text = "Not Found";
            txtBoxYer.Text = "Not Found";
            txtBoxHis.Text = "Not Found";
            txtBoxStree.Text = "Not Found";
            txtBoxPhoto.Text = "Not Found";
        }
    
        private void radBtnSighUpd_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "ID:";
            label7.Text = "Название Памятника:";
            label8.Text = "Год:";
            label5.Text = "Автор:";
            label6.Text = "История:";
        }

        private void radBtnStreUpd_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "ID:";
            label7.Text = "Улица:";
            label8.Text = " ";
            label5.Text = "Город ";
            label6.Text = " ";
            txtBoxYearUp.Text = "Not Found";
            txtBoxHisUp.Text = "Not Found";

        }

        private void radBtnCityUpd_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "ID:";
            label7.Text = "Город";
            label5.Text = " ";
            label6.Text = " ";
            txtBoxAutUp.Text = "Not Found";
            txtBoxYearUp.Text = "Not Found";
            txtBoxHisUp.Text = "Not Found";

        }




        #endregion
        //кнопка просмотр фото
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string file = @"C:\img\math.jpg";
            System.Diagnostics.Process.Start(file);
        }
        //Меню выбор базы sights
        private async void sightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "id ";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Год";
            dataGridView1.Columns[3].HeaderText = "Автор ";
            dataGridView1.Columns[4].HeaderText = "История ";
            dataGridView1.Columns[5].HeaderText = "Фото ";
            dataGridView1.Columns[6].HeaderText = "id Улицы ";
            sql = "SELECT  * from sights";
            // объект для выполнения SQL-за

            await conn.OpenAsync();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = null;
            //вывод в DataGriv БД
            #region
            try
            {
                List<string[]> data = new List<string[]>();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            reader.Close();
            conn.Close();
            #endregion

        }
        //Меню выбора базы city
        private async void cityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // объект для выполнения SQL-за
            sql = "SELECT  * from city";
            await conn.OpenAsync();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = null;
            dataGridView1.Columns[0].HeaderText = "id Города";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = " ";
            dataGridView1.Columns[3].HeaderText = " ";
            dataGridView1.Columns[4].HeaderText = " ";
            dataGridView1.Columns[5].HeaderText = " ";
            dataGridView1.Columns[6].HeaderText = " ";
            //вывод в DataGriv БД
            #region
            try
            {
                List<string[]> data = new List<string[]>();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[2]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    //data[data.Count - 1][2] = reader[2].ToString();
                    //data[data.Count - 1][3] = reader[3].ToString();
                    // data[data.Count - 1][4] = reader[4].ToString();
                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            reader.Close();
            conn.Close();
            #endregion
        }
        //Меню выбора базы street
        private async void streetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // объект для выполнения SQL-за
            dataGridView1.Columns[0].HeaderText = "id Улицы";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "id Города";
            dataGridView1.Columns[3].HeaderText = " ";
            dataGridView1.Columns[4].HeaderText = " ";
            dataGridView1.Columns[5].HeaderText = " ";
            dataGridView1.Columns[6].HeaderText = " ";
            sql = "SELECT  * from street";
            await conn.OpenAsync();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = null;
            //вывод в DataGriv БД
            #region
            try
            {
                List<string[]> data = new List<string[]>();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    //data[data.Count - 1][3] = reader[3].ToString();
                    // data[data.Count - 1][4] = reader[4].ToString();
                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            reader.Close();
            conn.Close();
            #endregion
        }
    }
}
