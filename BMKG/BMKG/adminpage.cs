using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class adminpage : Form
    {
        MySqlConnection con;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlCommandBuilder cmdbl;
       
        public adminpage(string username)
        {
            InitializeComponent();
            label7.Text = username;
            usernameadmin_txt.Text = username;
            FillComboKecamatan();
            loadDataNews();
        }

        void FillComboKecamatan()
        {
            string constring = "server=localhost;database=bmkg;uid=root;password=;";
            string Query = "select distinct WILAYAH from tabel_klimatologi";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sWilayah = myReader.GetString("WILAYAH");
                    comboBox1.Items.Add(sWilayah);
                }
            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
            }

        }

        private void load_data_db_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            string connectionSQL = "server=localhost;database=bmkg;uid=root;password=;";

            try
            {
                MySqlConnection db = new MySqlConnection(connectionSQL);
                MySqlDataAdapter data = new MySqlDataAdapter();
                MySqlCommand command = db.CreateCommand();
                command.CommandText = "select ID, WILAYAH, KECEPATAN_ANGIN, ARAH_ANGIN, CURAH_HUJAN, SUHU, KELEMBABAN, WAKTU from tabel_klimatologi where WILAYAH = '" + comboBox1.Text + "' and WAKTU between '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'";
                data.SelectCommand = command;
                DataSet dataset = new DataSet();
                data.Fill(dataset, "hasil");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "hasil";

            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
            }
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.Columns[7].Width = 90;
        }

        private void loadchart_btn_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;database=bmkg;uid=root;password=;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select ID, WILAYAH, KECEPATAN_ANGIN, ARAH_ANGIN, CURAH_HUJAN, SUHU, KELEMBABAN, WAKTU from tabel_klimatologi where WILAYAH = '" + comboBox1.Text + "' and WAKTU between '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Kecepatan Angin"].Points.AddXY(myReader.GetString("WAKTU"), myReader.GetString("KECEPATAN_ANGIN"));
                    this.chart2.Series["Suhu"].Points.AddXY(myReader.GetString("WAKTU"), myReader.GetString("SUHU"));
                    this.chart3.Series["Kelembaban Udara"].Points.AddXY(myReader.GetString("WAKTU"), myReader.GetString("KELEMBABAN"));
                }
            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out Success !");
            this.Hide();
            Form bmkg = new BMKG();
            bmkg.Show();
        }


        void loadDataNews()
        {
            DateTime tgl = DateTime.Now;
            label6.Text = tgl.ToShortDateString();
            
            
            //string connectionSQL = "server=localhost;database=bmkg;uid=root;password=;";

            try
            {
                con = new MySqlConnection();
                con.ConnectionString = "server=localhost;database=bmkg;uid=root;password=;";
                con.Open();
                adap = new MySqlDataAdapter("select * from news", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "news_detail");
                dataGridView2.DataSource = ds.Tables[0];
                /*MySqlConnection db = new MySqlConnection(connectionSQL);
                MySqlDataAdapter data = new MySqlDataAdapter();
                MySqlCommand command = db.CreateCommand();
                command.CommandText = "select * from news";
                data.SelectCommand = command;
                DataSet dataset = new DataSet();
                data.Fill(dataset, "hasil");
                dataGridView2.DataSource = dataset;
                dataGridView2.DataMember = "hasil";*/

            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
            }
            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].Width = 250;
            dataGridView2.Columns[2].Width = 600;
            dataGridView2.Columns[3].Width = 120;

        }

        private void savenews_btn_Click(object sender, EventArgs e)
        {
            
            DateTime tgl = DateTime.Now;
            
            string constring = "server=localhost;database=bmkg;uid=root;password=;";
            string Query = "insert into news (judul,isi,tanggal) values ('"+this.judulnews_txt.Text+"','"+this.isinews_txt.Text+"','"+this.label6.Text+"')";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 350;
            dataGridView2.Columns[3].Width = 60;
            
            loadDataNews();
        }

        private void updtnews_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                cmdbl = new MySqlCommandBuilder(adap);
                adap.Update(ds, "news_detail");
                MessageBox.Show("News Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string constring = "server=localhost;database=bmkg;uid=root;password=;";
            string Query = "select * from user_ms where username = '" + this.usernameadmin_txt.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    //string susername = myReader.GetString("username");
                    string spass = myReader.GetString("pass");
                    string snama = myReader.GetString("nama");
                    string semail = myReader.GetString("email");
                    string stgl_lahir = myReader.GetDateTime("tgl_lahir").ToString();
                    string sgender = myReader.GetString("gender");
                    string salamat = myReader.GetString("alamat");

                    passadmin_txt.Text = spass;
                    namaadmin_txt.Text = snama;
                    emailadmin_txt.Text = semail;
                    tgllahiradmin_dttmpckr.Text = stgl_lahir;
                    genderadmin_cbbx.Text = sgender;
                    alamatadmin_txt.Text = salamat;
                    
                    

                }
            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
            }
        }

        private void updateprofil_btn_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;database=bmkg;uid=root;password=;";
            string Query = "update user_ms set nama = '" + namaadmin_txt.Text + "', email = '" + emailadmin_txt.Text + "', tgl_lahir = '" + tgllahiradmin_dttmpckr.Text + "', gender = '" + genderadmin_cbbx.Text + "', alamat = '" + alamatadmin_txt.Text + "' where username = '" + usernameadmin_txt.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data Diri Telah Berhasil Diubah!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatepass_btn_Click(object sender, EventArgs e)
        {
            if (passadmin_txt.Text == passlama_txt.Text)
            {
                if (passbaru_txt.Text == re_passbaru_txt.Text)
                {
                    string constring = "server=localhost;database=bmkg;uid=root;password=;";
                    string Query = "update user_ms set pass = '"+re_passbaru_txt.Text+"' where username = '"+usernameadmin_txt.Text+"'";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;

                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Password telah Berubah!");
                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password Baru Tidak Sama, Re-Enter Password Baru");
                }
            }
            else
            {
                MessageBox.Show("Password Lama Tidak Sesuai dengan Database, Re-Enter Password Lama");
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

            

              


    }
}
