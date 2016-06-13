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
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class BMKG : Form
    {
        void splash()
        {
         Thread t = new Thread(new ThreadStart(Splashstart));
           t.Start();
           Thread.Sleep(4000);
            t.Abort();
        }
       public BMKG()
        {
          
           InitializeComponent();
           splash();
            LoadDataHariIni();
            fill_listbox();
            avgsuhu();
            avglbb();
            avgkec();
            avghuj();
            loadmaxmin();
        }

       public void Splashstart()
       {
           Application.Run(new Frm_Splash());
       }
       void loadmaxmin()
       {
           int maxlembab = dataGridView1.Rows.Cast<DataGridViewRow>().Max(s => Convert.ToInt32(s.Cells[6].Value));
           int minlembab = dataGridView1.Rows.Cast<DataGridViewRow>().Min(s => Convert.ToInt32(s.Cells[6].Value));
           
           int maxsuhu = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[5].Value));
           int minsuhu = dataGridView1.Rows.Cast<DataGridViewRow>().Min(r => Convert.ToInt32(r.Cells[5].Value));
           
           decimal maxhuj = dataGridView1.Rows.Cast<DataGridViewRow>().Max(t => Convert.ToDecimal(t.Cells[4].Value));
           decimal minhuj = dataGridView1.Rows.Cast<DataGridViewRow>().Min(t => Convert.ToDecimal(t.Cells[4].Value));
           
           decimal maxkec = dataGridView1.Rows.Cast<DataGridViewRow>().Max(u => Convert.ToDecimal(u.Cells[2].Value));
           decimal minkec = dataGridView1.Rows.Cast<DataGridViewRow>().Min(u => Convert.ToDecimal(u.Cells[2].Value));

           lbl_maxlembab.Text = maxlembab.ToString();
           lbl_minlembab.Text = minlembab.ToString();
           
           lbl_maxsuhu.Text = maxsuhu.ToString();
           lbl_minsuhu.Text = minsuhu.ToString();
           
           
           lbl_maxhuj.Text = maxhuj.ToString();
           lbl_minhuj.Text = minhuj.ToString();
           
           lbl_maxkec.Text = maxkec.ToString();
           lbl_minkec.Text = minkec.ToString();
       }

       void avgkec()
       {
           decimal sumkec = 0;
           for (int ikec = 0; ikec < dataGridView1.Rows.Count; ++ikec)
           {
               sumkec += Convert.ToDecimal(dataGridView1.Rows[ikec].Cells[2].Value);
           }
           int count_rowkec = dataGridView1.Rows.Count;
           decimal avgkec = sumkec / count_rowkec;
           txt_avgkec.Text = avgkec.ToString("n2");

           if (Convert.ToDouble(txt_avgkec.Text) <= 15)
           {
               txt_avgkec.BackColor = Color.Lime;
           }
           else if (Convert.ToDouble(txt_avgkec.Text) >= 25)
           {
               txt_avgkec.BackColor = Color.IndianRed;
           }
           else
           {
               txt_avgkec.BackColor = Color.Yellow;
           }
       }

       void avghuj()
       {
           decimal sumhuj = 0;
           for (int ihuj = 0; ihuj < dataGridView1.Rows.Count; ++ihuj)
           {
               sumhuj += Convert.ToDecimal(dataGridView1.Rows[ihuj].Cells[4].Value);
           }
           int count_rowhuj = dataGridView1.Rows.Count;
           decimal avghuj = sumhuj / count_rowhuj;
           txt_avghuj.Text = avghuj.ToString("n2");

           if (Convert.ToDouble(txt_avghuj.Text) <= 15)
           {
               txt_avghuj.BackColor = Color.Lime;
           }
           else if (Convert.ToDouble(txt_avghuj.Text) >= 25)
           {
               txt_avghuj.BackColor = Color.IndianRed;
           }
           else
           {
               txt_avghuj.BackColor = Color.Yellow;
           }
       }

       
        
        void avgsuhu()
       {
           int sumsuhu = 0;
           for (int isuhu = 0; isuhu < dataGridView1.Rows.Count; ++isuhu)
           {
               sumsuhu += Convert.ToInt32(dataGridView1.Rows[isuhu].Cells[5].Value);
           }
           int count_rowsuhu = dataGridView1.Rows.Count;
           double avgsuhu = sumsuhu / count_rowsuhu;
           txt_avgsuhu.Text = avgsuhu.ToString();

           if (Convert.ToInt32(txt_avgsuhu.Text) <= 15)
           {
               txt_avgsuhu.BackColor = Color.Lime;
           }
           else if (Convert.ToInt32(txt_avgsuhu.Text) >=25)
           {
               txt_avgsuhu.BackColor = Color.IndianRed;
           }else
           {
               txt_avgsuhu.BackColor = Color.Yellow;
           }


       }

       void avglbb()
       {
           int sumlbb = 0;
           for (int ilbb = 0; ilbb < dataGridView1.Rows.Count; ++ilbb)
           {
               sumlbb += Convert.ToInt32(dataGridView1.Rows[ilbb].Cells[6].Value);
           }
           int count_rowlbb = dataGridView1.Rows.Count;
           double avglbb = sumlbb / count_rowlbb;
           txt_avglembab.Text = avglbb.ToString();

           if (Convert.ToInt32(txt_avglembab.Text) <= 15)
           {
               txt_avglembab.BackColor = Color.Lime;
           }
           else if (Convert.ToInt32(txt_avglembab.Text) >= 25)
           {
               txt_avglembab.BackColor = Color.IndianRed;
           }
           else
           {
               txt_avglembab.BackColor = Color.Yellow;
           }
       }


       void fill_listbox()
       {
           string constring = "server=localhost;database=bmkg;uid=root;password=;";
           string Query = "select judul from news";
           MySqlConnection conDataBase = new MySqlConnection(constring);
           MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
           MySqlDataReader myReader;
           try
           {
               conDataBase.Open();
               myReader = cmdDataBase.ExecuteReader();

               while (myReader.Read())
               {
                   string sjudul = myReader.GetString("judul");
                   listBox1.Items.Add(sjudul);
               }
           }
           catch (Exception kesalahan)
           {
               MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
           }
       }

       void LoadDataHariIni()
       {
           string connectionSQL = "server=localhost;database=bmkg;uid=root;password=;";

           try
           {
               MySqlConnection db = new MySqlConnection(connectionSQL);
               MySqlDataAdapter data = new MySqlDataAdapter();
               MySqlCommand command = db.CreateCommand();
               command.CommandText = "select ID, WILAYAH, KECEPATAN_ANGIN, ARAH_ANGIN, CURAH_HUJAN, SUHU, KELEMBABAN, DATE_TIME from tabel_klimatologi where WAKTU = '2014-06-21'";
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

        

      
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new login();
            frm2.Show();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new login();
            frm2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "server=localhost;database=bmkg;uid=root;password=;";
            string Query = "select tanggal, isi from news where judul = '"+listBox1.Text+"'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sisi = myReader.GetString("isi");
                    string stgl = myReader.GetString("tanggal");
                    richTextBox1.Text = sisi ;
                    
                    //MessageBox.Show(sisi, "Berita Tanggal :" +stgl);
                    //isinews_txt.Text = sisi;
                    //tglnews_txt.Text = stgl;
                    
                }
            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("terjadi kesalahan karena: " + kesalahan);
            }
        }

        private void BMKG_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        
    }
}
