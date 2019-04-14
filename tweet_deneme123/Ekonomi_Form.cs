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
    public partial class Ekonomi_Form : Form
    {
        public Ekonomi_Form()
        {
            InitializeComponent();
        }

        int ek = 0;
        int a = 0;
        string[] dizi1 = new string[110];
        string[] diziusd = new string[110];

        DataTable dtEkonomi = new DataTable();
        DataTable dtusd = new DataTable();


        TwitterService tweetservis = new TwitterService("5F6jZRRTAVtmsCKwfKQf3vdy7", "PavU95R7s3LOUAZ5DF0sEE6pQ7HkR6qOtvTSTels7yfOAR56zQ", "951929077958631425-ClSn5Vq33Km2TprRZrNznZuflMelsLL", "Fq8pOhoh6ztUuuiU8Ylr4EOVsfOOHHebWLlzt1XwMPTIA");
        private void Ekonomi_Form_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var veriler = tweetservis.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions() { Count = 500 });
            foreach (var item in veriler)
            {

                listBox1.Items.Add(item.User.Name + "   " + item.Text);

            }

            System.Threading.Thread.Sleep(1000);

            this.chart3.Titles.Add("Gün içerisindeki USD değişikliği");
            a = 0;
            ek = 0;
            listBox2.DataSource = Ekonomi();
            listBox2.DisplayMember = "Ekonomi";
            listBox3.DataSource = usd();
            listBox3.DisplayMember = "usd";


            DataView dvEkonomi = dtEkonomi.DefaultView;
            dvEkonomi.RowFilter = "Ekonomi LIKE '%" + "para" + "%'";

            DataView dvusd = dtusd.DefaultView;
            dvusd.RowFilter = "usd LIKE '%" + "usd" + "%'";


            for (int k = 0; k < 100; k++)
            {
                dizi1[a] = Convert.ToString(listBox1.Items[k]);
                dtEkonomi.Rows.Add(dizi1[a]);
                a++;
                
            }

            for (int k1 = 0; k1 < 100; k1++)
            {
                diziusd[ek] = Convert.ToString(listBox1.Items[k1]);
                dtusd.Rows.Add(diziusd[ek]);
                ek++;
            }

            int sayacusd = listBox3.Items.Count;
            this.chart3.Series["USD"].Points.AddY(sayacusd);
        }

        private DataTable Ekonomi()
        {
            dtEkonomi.Columns.Add("Ekonomi", typeof(string));
            return dtEkonomi;
        }

        private DataTable usd()
        {
            dtusd.Columns.Add("usd", typeof(string));
            return dtusd;
        }
    }
}
