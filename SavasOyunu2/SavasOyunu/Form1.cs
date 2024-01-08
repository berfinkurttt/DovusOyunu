using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SavasOyunu
{
    public partial class Form1 : Form
    {
        Ulke taraf1 = new Ulke();
        Ulke taraf2 = new Ulke();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pdmgbox.Visible = false;
            sdmgbox.Visible = false;
            pictureBox1.Image = SavasOyunu.Properties.Resources.s;
            pictureBox2.Image = SavasOyunu.Properties.Resources.p;
            listView1.Clear();
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Tarih", 120);
            listView1.Columns.Add("Kazanan", 100);
            listView1.Columns.Add("Kaybeden", 100);

            XmlDocument xmlOyun = new XmlDocument();
            xmlOyun.LoadXml(SavasOyunu.Properties.Resources.oyun);
            XmlNode xmlRoot = xmlOyun.SelectSingleNode("oyun");

            foreach (XmlNode item in xmlRoot.SelectNodes("oynanan"))
            {
                string[] oyun = new string[3];
                oyun[0] = item.SelectSingleNode("tarih").InnerText;
                oyun[1] = item.SelectSingleNode("kazanan").InnerText;
                oyun[2] = item.SelectSingleNode("kaybeden").InnerText;
                listView1.Items.Add(new ListViewItem(oyun));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int yt = random.Next(2);
            taraf1.Can = 100;
            taraf2.Can = 100;
            if (yt == 1)
            {
                pictureBox1.Enabled = true;
            }
            else
            {
                pictureBox2.Enabled = true;
            }
            button1.Enabled = false;
            pcanlabel.Text = Convert.ToString(taraf1.Can);
            scanlabel.Text = Convert.ToString(taraf2.Can);
            label1.Text = "Hasar";
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            taraf1.UlkeAd = "P";
            taraf2.UlkeAd = "S";
            if (pictureBox1.Enabled == true)
            {
                int dmg = taraf1.hasar();
                taraf2.Can -= dmg;



                scanlabel.Text = Convert.ToString(taraf2.Can);
                label1.Text = "---->>>> " + Convert.ToString(dmg);
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = true;
                listBox1.Items.Add(dmg + " P tarafından vurulan hasar");
                if (taraf2.Can <= 0)
                {
                    scanlabel.Text = "0";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = false;
                    sdmgbox.Enabled = true;
                    sdmgbox.Visible = true;
                    //MessageBox.Show(" P Tarafı Oyunu kazandı");

                    XmlDocument xmlOyun = new XmlDocument();
                    xmlOyun.LoadXml(SavasOyunu.Properties.Resources.oyun);
                    XmlNode xmlRoot = xmlOyun.SelectSingleNode("oyun");

                    XmlNode ana = xmlOyun.CreateElement("oynanan");

                    XmlNode tarih = xmlOyun.CreateElement("tarih");
                    tarih.InnerText = Convert.ToString(DateTime.Now);
                    ana.AppendChild(tarih);

                    XmlNode kazanan = xmlOyun.CreateElement("kazanan");
                    kazanan.InnerText = taraf1.UlkeAd;
                    ana.AppendChild(kazanan);

                    XmlNode kaybeden = xmlOyun.CreateElement("kaybeden");
                    kaybeden.InnerText = taraf2.UlkeAd;
                    ana.AppendChild(kaybeden);

                    xmlOyun.DocumentElement.AppendChild(ana);

                    string xmlFilePath = "../../Resources/oyun.xml";
                    xmlOyun.Save(xmlFilePath);

                    button2.Enabled = false;
                    button1.Enabled = false;
                    listView1.Items.Clear();
                    foreach (XmlNode item in xmlRoot.SelectNodes("oynanan"))
                    {
                        string[] oyun = new string[3];
                        oyun[0] = item.SelectSingleNode("tarih").InnerText;
                        oyun[1] = item.SelectSingleNode("kazanan").InnerText;
                        oyun[1] = item.SelectSingleNode("kaybeden").InnerText;
                        listView1.Items.Add(new ListViewItem(oyun));
                    }

                    label1.Text = "G/O";
                }
            }
            else
            {
             
                int dmg2 = taraf1.hasar();
                taraf1.Can -= dmg2;
             

                pcanlabel.Text = Convert.ToString(taraf1.Can);
                label1.Text = Convert.ToString(dmg2) + " <<<<----";
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = false;
                listBox1.Items.Add(dmg2 + " S tarafından vurulan hasar");
                if (taraf1.Can <= 0)
                {
                    pcanlabel.Text = "0";
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = true;
                    pdmgbox.Enabled = true;
                    pdmgbox.Visible = true;
                    //MessageBox.Show(" S Tarafı Oyunu kazandı");

                    XmlDocument xmlOyun = new XmlDocument();
                    xmlOyun.LoadXml(SavasOyunu.Properties.Resources.oyun);
                    XmlNode xmlRoot = xmlOyun.SelectSingleNode("oyun");

                    XmlNode ana = xmlOyun.CreateElement("oynanan");

                    XmlNode tarih = xmlOyun.CreateElement("tarih");
                    tarih.InnerText = Convert.ToString(DateTime.Now);
                    ana.AppendChild(tarih);

                    XmlNode kazanan = xmlOyun.CreateElement("kazanan");
                    kazanan.InnerText = taraf2.UlkeAd;
                    ana.AppendChild(kazanan);

                    XmlNode kaybeden = xmlOyun.CreateElement("kaybeden");
                    kaybeden.InnerText = taraf1.UlkeAd;
                    ana.AppendChild(kaybeden);

                    xmlOyun.DocumentElement.AppendChild(ana);

                    ana.ToString();

                    string xmlFilePath = "../../Resources/oyun.xml";
                    xmlOyun.Save(xmlFilePath);

                    button2.Enabled = false;
                    button1.Enabled = false;
                    listView1.Items.Clear();
                    foreach (XmlNode item in xmlRoot.SelectNodes("oynanan"))
                    {
                        string[] oyun = new string[3];
                        oyun[0] = item.SelectSingleNode("tarih").InnerText;
                        oyun[1] = item.SelectSingleNode("kazanan").InnerText;
                        oyun[1] = item.SelectSingleNode("kaybeden").InnerText;
                        listView1.Items.Add(new ListViewItem(oyun));
                    }
                    
                    label1.Text = "G/O";
                }
            }
        }
    }
}
