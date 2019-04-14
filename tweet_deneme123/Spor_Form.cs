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

namespace tweet_deneme123
{
    public partial class Spor_Form : Form
    {
        public Spor_Form()
        {
            InitializeComponent();
        }

        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        string[] dizigs = new string[110];
        string[] dizifb = new string[110];
        string[] dizibsk = new string[110];
        string[] dizi1 = new string[110];
        DataTable dtgs = new DataTable();
        DataTable dtfb = new DataTable();
        DataTable dtbsk = new DataTable();
        DataTable dtSpor = new DataTable();

        TwitterService tweetservis = new TwitterService("5F6jZRRTAVtmsCKwfKQf3vdy7", "PavU95R7s3LOUAZ5DF0sEE6pQ7HkR6qOtvTSTels7yfOAR56zQ", "951929077958631425-ClSn5Vq33Km2TprRZrNznZuflMelsLL", "Fq8pOhoh6ztUuuiU8Ylr4EOVsfOOHHebWLlzt1XwMPTIA");

        private void Spor_Form_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var veriler = tweetservis.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions() { Count = 500 });
            foreach (var item in veriler)
            {

                listBox1.Items.Add(item.User.Name + "   " + item.Text);

            }

            System.Threading.Thread.Sleep(1000);

            this.chart1.Titles.Add("Hangi takım hakkında ne kadar çok tweet'de bahsedilmiş");
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            listBox2.DataSource = Spor();
            listBox2.DisplayMember = "Spor";
            listBox3.DataSource = gs();
            listBox3.DisplayMember = "gs";
            listBox4.DataSource = fb();
            listBox4.DisplayMember = "fb";
            listBox5.DataSource = bsk();
            listBox5.DisplayMember = "bsk";



            DataView dvSpor = dtSpor.DefaultView;
            dvSpor.RowFilter = "Spor LIKE '%" + "Spor" + "%'";


            DataView dvgs = dtgs.DefaultView;
            dvgs.RowFilter = "gs LIKE '%" + "galatasaray" + "%'";

            DataView dvfb = dtfb.DefaultView;
            dvfb.RowFilter = "fb LIKE '%" + "fenerbahçe" + "%'";

            DataView dvbsk = dtbsk.DefaultView;
            dvbsk.RowFilter = "bsk LIKE'%" + "beşiktaş" + "%'";

            for (int j = 0; j < 100; j++)
            {
                dizi1[a] = Convert.ToString(listBox1.Items[j]);
                dtSpor.Rows.Add(dizi1[a]);
                a++;
            }
            for (int n = 0; n < 100; n++)
            {
                dizigs[b] = Convert.ToString(listBox1.Items[n]);
                dtgs.Rows.Add(dizigs[b]);
                b++;

            }

            for (int m = 0; m < 100; m++)
            {
                dizibsk[c] = Convert.ToString(listBox1.Items[m]);
                dtbsk.Rows.Add(dizibsk[c]);
                c++;
            }

            for (int m1 = 0; m1 < 100; m1++)
            {
                dizifb[d] = Convert.ToString(listBox1.Items[m1]);
                dtfb.Rows.Add(dizifb[d]);
                d++;
            }
            int sayacgs = listBox3.Items.Count;
            int sayacfb = listBox4.Items.Count;
            int sayacbsk = listBox5.Items.Count;



            this.chart1.Series["Galatasaray"].Points.AddY(sayacgs);
            this.chart1.Series["Fenerbahçe"].Points.AddY(sayacfb);
            this.chart1.Series["Beşiktaş"].Points.AddY(sayacbsk);
        }

        private DataTable Spor()
        {
            dtSpor.Columns.Add("Spor", typeof(string));
            return dtSpor;
        }


        private DataTable gs()
        {
            dtgs.Columns.Add("gs", typeof(string));
            return dtgs;
        }

        private DataTable bsk()
        {
            dtbsk.Columns.Add("bsk", typeof(string));
            return dtbsk;
        }

        private DataTable fb()
        {
            dtfb.Columns.Add("fb", typeof(string));
            return dtfb;
        }
    }
}
