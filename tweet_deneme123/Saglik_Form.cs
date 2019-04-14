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
    public partial class Saglik_Form : Form
    {
        public Saglik_Form()
        {
            InitializeComponent();
        }

        int cck = 0;
        int a = 0;

        DataTable dtSaglik = new DataTable();
        DataTable dtcocuk = new DataTable();

        string[] dizicocuk = new string[110];
        string[] dizi1 = new string[110];


        TwitterService tweetservis = new TwitterService("5F6jZRRTAVtmsCKwfKQf3vdy7", "PavU95R7s3LOUAZ5DF0sEE6pQ7HkR6qOtvTSTels7yfOAR56zQ", "951929077958631425-ClSn5Vq33Km2TprRZrNznZuflMelsLL", "Fq8pOhoh6ztUuuiU8Ylr4EOVsfOOHHebWLlzt1XwMPTIA");

        private void Saglik_Form_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var veriler = tweetservis.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions() { Count = 500 });
            foreach (var item in veriler)
            {

                listBox1.Items.Add(item.User.Name + "   " + item.Text);

            }

            System.Threading.Thread.Sleep(1000);

            this.chart2.Titles.Add("Çocuklar ile ilgili atılan tweet sayısı");
            a = 0;
            cck = 0;
            listBox2.DataSource = Saglik();
            listBox2.DisplayMember = "Saglik";
            listBox3.DataSource = cocuk();
            listBox3.DisplayMember = "cocuk";


            DataView dvSaglik = dtSaglik.DefaultView;
            dvSaglik.RowFilter = "Saglik LIKE '%" + "sağlık" + "%'";

            DataView dvcocuk = dtcocuk.DefaultView;
            dvcocuk.RowFilter = "cocuk LIKE '%" + "çocuk" + "%'";



            for (int i = 0; i < 100; i++)
            {
                dizi1[a] = Convert.ToString(listBox1.Items[i]);
                dtSaglik.Rows.Add(dizi1[a]);
                a++;
            }

            for (int i1 = 0; i1 < 100; i1++)
            {
                dizicocuk[cck] = Convert.ToString(listBox1.Items[i1]);
                dtcocuk.Rows.Add(dizicocuk[cck]);
                cck++;
            }

            int sayaccocuk = listBox3.Items.Count;
            int sayacsaglik = listBox2.Items.Count;
            
            this.chart2.Series["Çocuk"].Points.AddY(sayaccocuk);
            this.chart2.Series["Diğerleri"].Points.AddY(sayacsaglik);
        }

        private DataTable cocuk()
        {
            dtcocuk.Columns.Add("cocuk", typeof(string));
            return dtcocuk;
        }

        private DataTable Saglik()
        {
            dtSaglik.Columns.Add("Saglik", typeof(string));
            return dtSaglik;
        }
    }
}
