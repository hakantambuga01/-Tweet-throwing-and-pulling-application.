using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;
using System.Threading;



namespace tweet_deneme123
{




    public partial class Form1 : Form
    {

        //int a = 0;
        //int b = 0;
        //int c = 0;
        //int d = 0;
        //int cck = 0;
        //int ek = 0;
        //string[] dizi1 = new string[110];
        //string[] dizigs = new string[110];
        //string[] dizifb = new string[110];
        //string[] dizibsk = new string[110];
        //string[] dizicocuk = new string[110];
        //string[] diziusd = new string[110];

        //DataTable dtSaglik = new DataTable();
        //DataTable dtSpor = new DataTable();
        //DataTable dtEkonomi = new DataTable();
        //DataTable dtgs = new DataTable();
        //DataTable dtfb = new DataTable();
        //DataTable dtbsk = new DataTable();
        //DataTable dtcocuk = new DataTable();
        //DataTable dtusd = new DataTable();





        TwitterService tweetservis = new TwitterService("5F6jZRRTAVtmsCKwfKQf3vdy7", "PavU95R7s3LOUAZ5DF0sEE6pQ7HkR6qOtvTSTels7yfOAR56zQ", "951929077958631425-ClSn5Vq33Km2TprRZrNznZuflMelsLL", "Fq8pOhoh6ztUuuiU8Ylr4EOVsfOOHHebWLlzt1XwMPTIA");




        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            var veriler = tweetservis.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions() { Count = 500});
            foreach (var item in veriler)
            {

                listBox1.Items.Add(item.User.Name + "   " + item.Text);

            }

        }


        //   <<<<<------------------------------_______________SAGLIK____________----------------------------->>>>


        private void button1_Click(object sender, EventArgs e)
        {
            Saglik_Form saglikForm = new Saglik_Form();
            saglikForm.Show();


            //this.chart2.Titles.Add("Çocuklar ile ilgili atılan tweet sayısı");
            //a = 0;
            //cck = 0;
            //listBox2.DataSource = Saglik();
            //listBox2.DisplayMember = "Saglik";
            //listBox8.DataSource = cocuk();
            //listBox8.DisplayMember="cocuk";


            //DataView dvSaglik = dtSaglik.DefaultView;
            //dvSaglik.RowFilter = "Saglik LIKE '%" + "sağlık" + "%'";

            //DataView dvcocuk = dtcocuk.DefaultView;
            //dvcocuk.RowFilter = "cocuk LIKE '%" + "çocuk" + "%'";
          


            //for (int i = 0; i < 100; i++)
            //{
            //    dizi1[a] = Convert.ToString(listBox1.Items[i]);
            //    dtSaglik.Rows.Add(dizi1[a]);
            //    a++;
            //}

            //for(int i1=0; i1<100; i1++)
            //{
            //    dizicocuk[cck] = Convert.ToString(listBox1.Items[i1]);
            //    dtcocuk.Rows.Add(dizicocuk[cck]);
            //    cck++;
            //}

            //int sayaccocuk = listBox8.Items.Count;
            //int sayacsaglik = listBox2.Items.Count;
            //int cıkarma = sayacsaglik - sayaccocuk;
            //this.chart2.Series["Çocuk"].Points.AddY(sayaccocuk);
            //this.chart2.Series["Diğerleri"].Points.AddY(cıkarma);
             
        }





        // <<<<<------------------------------_______________SPOR____________----------------------------->>>>
        private void button4_Click_1(object sender, EventArgs e)
        {
            Spor_Form sporac = new Spor_Form();
            sporac.Show();


            //this.chart1.Titles.Add("Hangi takım hakkında ne kadar çok tweet'de bahsedilmiş");
            //a = 0;
            //b = 0;
            //c = 0;
            //d = 0;
            //listBox3.DataSource = Spor();
            //listBox3.DisplayMember = "Spor";
            //listBox5.DataSource = gs();
            //listBox5.DisplayMember = "gs";
            //listBox6.DataSource = fb();
            //listBox6.DisplayMember = "fb";
            //listBox7.DataSource = bsk();
            //listBox7.DisplayMember = "bsk";



            //DataView dvSpor = dtSpor.DefaultView;
            //dvSpor.RowFilter = "Spor LIKE '%" + "Spor" + "%'";

            
            //DataView dvgs = dtgs.DefaultView;
            //dvgs.RowFilter = "gs LIKE '%" + "galatasaray" + "%'";

            //DataView dvfb = dtfb.DefaultView;
            //dvfb.RowFilter = "fb LIKE '%" + "fenerbahçe" + "%'";

            //DataView dvbsk = dtbsk.DefaultView;
            //dvbsk.RowFilter = "bsk LIKE'%" + "beşiktaş" + "%'";

            //for (int j = 0; j < 100; j++)
            //{
            //    dizi1[a] = Convert.ToString(listBox1.Items[j]);
            //    dtSpor.Rows.Add(dizi1[a]);
            //    a++;
            //}
            //for(int n=0; n<100; n++)
            //{
            //    dizigs[b] = Convert.ToString(listBox1.Items[n]);
            //    dtgs.Rows.Add(dizigs[b]);
            //    b++;
                
            //}

            //for (int m = 0; m < 100; m++)
            //{
            //    dizibsk[c] = Convert.ToString(listBox1.Items[m]);
            //    dtbsk.Rows.Add(dizibsk[c]);
            //    c++;
            //}

            //for(int m1=0; m1<100; m1++)
            //{
            //    dizifb[d] = Convert.ToString(listBox1.Items[m1]);
            //    dtfb.Rows.Add(dizifb[d]);
            //    d++;
            //}
            //int sayacgs = listBox5.Items.Count;
            //int sayacfb = listBox6.Items.Count;
            //int sayacbsk = listBox7.Items.Count;
           
            

            //this.chart1.Series["Galatasaray"].Points.AddY(sayacgs);
            //this.chart1.Series["Fenerbahçe"].Points.AddY(sayacfb);
            //this.chart1.Series["Beşiktaş"].Points.AddY(sayacbsk);
        }

        // <<<<<------------------------------_______________EKONOMİ____________----------------------------->>>>
        private void button5_Click_1(object sender, EventArgs e)
        {
            Ekonomi_Form ekoForm = new Ekonomi_Form();
            ekoForm.Show();


            //this.chart3.Titles.Add("Gün içerisindeki USD değişikliği");
            //a = 0;
            //ek = 0;
            //listBox4.DataSource = Ekonomi();
            //listBox4.DisplayMember = "Ekonomi";
            //listBox9.DataSource = usd();
            //listBox9.DisplayMember = "usd";


            //DataView dvEkonomi = dtEkonomi.DefaultView;
            //dvEkonomi.RowFilter = "Ekonomi LIKE '%" + "para" + "%'";

            //DataView dvusd = dtusd.DefaultView;
            //dvusd.RowFilter = "usd LIKE '%" + "usd" + "%'";


            //for (int k = 0; k < 100; k++)
            //{
            //    dizi1[a] = Convert.ToString(listBox1.Items[k]);
            //    dtEkonomi.Rows.Add(dizi1[a]);
            //    a++;
            //}

            //for(int k1=0; k1<100; k1++)
            //{
            //    diziusd[ek] = Convert.ToString(listBox1.Items[k1]);
            //    dtusd.Rows.Add(diziusd[ek]);
            //    ek++;
            //}

            //int sayacusd = listBox9.Items.Count;
            //this.chart3.Series["USD"].Points.AddY(sayacusd);
        }


        // <<<<<------------------------------_______________BENİM  TWEETLERİM____________----------------------------->>>>
        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox10.Items.Clear();
            var veriler = tweetservis.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions() { Count = 100 });
            foreach (var item in veriler)
            {

                listBox10.Items.Add(item.Text);

            }
        }


        // <<<<<------------------------------_______________TWEET YOLLA____________----------------------------->>>>

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                tweetservis.SendTweet(new SendTweetOptions() { Status = textBox1.Text });
               
            }
            catch (Exception)
            {
                

            }
        }



        //private DataTable Saglik()
        //{
        //    dtSaglik.Columns.Add("Saglik", typeof(string));
        //    return dtSaglik;
        //}

        //private DataTable Spor()
        //{
        //    dtSpor.Columns.Add("Spor", typeof(string));
        //    return dtSpor;
        //}

        //private DataTable Ekonomi()
        //{
        //    dtEkonomi.Columns.Add("Ekonomi", typeof(string));
        //    return dtEkonomi;
        //}

        //private DataTable gs()
        //{
        //    dtgs.Columns.Add("gs", typeof(string));
        //    return dtgs;
        //}

        //private DataTable bsk()
        //{
        //    dtbsk.Columns.Add("bsk", typeof(string));
        //    return dtbsk;
        //}

        //private DataTable fb()
        //{
        //    dtfb.Columns.Add("fb", typeof(string));
        //    return dtfb;
        //}

        //private DataTable cocuk()
        //{
        //    dtcocuk.Columns.Add("cocuk", typeof(string));
        //    return dtcocuk;
        //}

        //private DataTable usd()
        //{
        //    dtusd.Columns.Add("usd", typeof(string));
        //    return dtusd;
        //}


    }
}

