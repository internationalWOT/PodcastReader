using ClassLibrary1.Entities;
using ClassLibrary1;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Logik;
using Logik.Service;
using System.Xml;
using System.Xml.Linq;
using WindowsFormsApp1;

namespace WindowsFormsApplication8
{
    public partial class Feeds : Form
    {

        LogikLager logikLager = new LogikLager();
        private List<Category> _categories;
        private XmlHanterare xmlHanterare;
        private TimerService timerService;



        public Feeds()
        {
            InitializeComponent();
            xmlHanterare = new XmlHanterare();
            _categories = xmlHanterare.GetAllCategories();
            
            FillCategorylist();
            fillUpdateList();
            timerService = new TimerService();



        }

        private void FillCategorylist()
        {
            foreach (var category in _categories)
            {
                ListCategories.Items.Add(category);
                kategoriCb.Items.Add(category);
                
            }
        }

        private void fillUpdateList()
        {
            uppdatIntervallCb.Items.Add("5000");
            uppdatIntervallCb.Items.Add("100000");
            uppdatIntervallCb.Items.Add("200000");

        }

        private void Feeds_Load(object sender, EventArgs e)
        {

        }

        private void ClearAll()
        {
            ListCategories.Items.Clear();
            ListPodcasts.Items.Clear();
            ListEpisodes.Items.Clear();

        }

        private async void sparaBtn_Click(object sender, EventArgs e)
        {
           
            if (Validering.textFieldNotEmpty(urlTextBox, "Url fält är tomt, ") && Validering.textFieldNotEmpty(namnField, "namn fält är tomt, ") && Validering.checkIfValidUrl(urlTextBox.Text))
            {
                if (kategoriCb.Text == null)

                {
                    MessageBox.Show("välj en kategori");
                }
               
                else
                {
                    var path = Directory.GetCurrentDirectory() + @"\" + kategoriCb.Text + @"\" + namnField.Text + ".xml";
                    xmlHanterare.AddNew(namnField.Text, path, kategoriCb.Text, uppdatIntervallCb.SelectedItem.ToString(), urlTextBox.Text);
                    ListCategories.Items.Clear();
                    ListEpisodes.Items.Clear();
                    ListPodcasts.Items.Clear();

                    kategoriCb.Items.Clear();
                    //cb_removeCat.Items.Clear();
                    await Task.Delay(1000);

                    MessageBox.Show(namnField.Text + " har nu blivit tillagd i " + kategoriCb.Text + ", Grattis...");
                    _categories = xmlHanterare.GetAllCategories();
                    FillCategorylist();
                }
            }


           
            
        }


        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ListPodcasts.Items.Clear();
            ListEpisodes.Items.Clear();
            var item = (Category)ListCategories.SelectedItem;
            foreach (var podcast in item.Podcasts)
            {
                ListPodcasts.Items.Add(podcast);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListCategories.Items.Clear();
            FillCategorylist();
            
            

        }

        private void ListPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Podcast)ListPodcasts.SelectedItem;

            var url = item.RssUrl;
            var updateInterval = item.UpdateInterval;

           
            timerService.queueNewUpdate(ListPodcasts.Text, ListCategories.Text, item, url);
            ListEpisodes.Items.Clear();
            
            
            ListEpisodes.Items.AddRange(item.Episodes.ToArray());
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            var episode = (Episode)ListEpisodes.SelectedItem;
            speladepodsLi.Items.Add(episode);
            episode.IsPlayed = true;
            

            xmlHanterare.Save(ListPodcasts.SelectedItem as Podcast);

            Process.Start(episode.Url);


        }

        private void laggTillNyKatBtn_Click(object sender, EventArgs e)
        {
            string path = laggTillKategoriCb.Text;
            {
                if (!Directory.Exists(path))
                {

                    if (!Validering.textEmpty(path))
                    {
                        Directory.CreateDirectory(path);
                        ListCategories.Items.Clear();
                        kategoriCb.Items.Clear();
                        //cb_removeCat.Items.Clear();
                        
                        _categories = xmlHanterare.GetAllCategories();
                        FillCategorylist();
                        MessageBox.Show("Kategori Skapad!");

                    }
                    else
                    {
                        MessageBox.Show("Textfältet är tomt");
                    }
                }

                else
                {
                    MessageBox.Show("Kategorin finns redan");
                }


            }
        }

        private void laggTillKategoriCb_TextChanged(object sender, EventArgs e)
        {

        }



        

        private void cb_removeCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RaderaUrl_Click(object sender, EventArgs e)
        {
            if (Validering.listBoxNotEmpty(ListPodcasts))
            {
                var resultat = MessageBox.Show("Är du säker på att du vill radera den markerade podden? ", "bekräfta",
                    MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    logikLager.remove(ListCategories.Text, ListPodcasts.Text);
                    ListEpisodes.Items.Clear();
                    ListPodcasts.Items.Clear();
                    ListCategories.Items.Clear();
                    MessageBox.Show("Pod permanent borttagen");
                    _categories = xmlHanterare.GetAllCategories();
                    FillCategorylist();

                }
                
            }
        }

        private void sparaNyUrlBtn_Click(object sender, EventArgs e)
        {
            if (Validering.textFieldNotEmpty(urlTextBox, "Url fält"))
            {
                if (ListPodcasts.SelectedItem == null)
                {
                    MessageBox.Show("var vänlig och välj en podcast från en categori att ändra namn på.");
                    return;
                }
                else
                {
                    var resultat = MessageBox.Show("vill du verkligen ändra URL","bekräfta",
                    MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes)
                    {
                        var pod = ListPodcasts.SelectedItem as Podcast;
                        logikLager.remove(ListCategories.Text, ListPodcasts.Text);
                        XmlHanterare xml = new XmlHanterare();
                        xmlHanterare.AddNew(pod.Title, pod.Path, kategoriCb.Text, pod.UpdateInterval,urlTextBox.Text);
                        ListCategories.Items.Clear();
                        ListEpisodes.Items.Clear();
                        ListPodcasts.Items.Clear();

                        kategoriCb.Items.Clear();
                        //cb_removeCat.Items.Clear();


                        //timerService
                        _categories = xmlHanterare.GetAllCategories();
                        FillCategorylist();
                    }
                        
                }
            }
        }

       

        private void update_updateInterval_Click(object sender, EventArgs e)
        {
            if (Validering.intervalBoxNotEmpty(uppdatIntervallCb))
            {
                if (ListPodcasts.SelectedItem == null)
                {
                    MessageBox.Show("var vänlig och välj en podcast att uppdatera uppdateringsintervallen, samt en uppdareringsintervall");
                    return;
                }
                else
                {
                    var resultat = MessageBox.Show("vill du verkligen uppdatera uppdateringsintervallen? ", "bekräfta",
                    MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes)
                    {
                        var pod = ListPodcasts.SelectedItem as Podcast;
                        logikLager.remove(ListCategories.Text, ListPodcasts.Text);
                        XmlHanterare xml = new XmlHanterare();
                        xmlHanterare.AddNew(pod.Title, pod.Path, ListCategories.Text, uppdatIntervallCb.Text, pod.RssUrl);
                        ListCategories.Items.Clear();
                        ListEpisodes.Items.Clear();
                        ListPodcasts.Items.Clear();

                        kategoriCb.Items.Clear();
                        //cb_removeCat.Items.Clear();


                        //timerService
                        _categories = xmlHanterare.GetAllCategories();
                        FillCategorylist();
                    }

                }
            }
        }

        private void bt_deleteCat_Click(object sender, EventArgs e)
        {
            if (Validering.listBoxNotEmpty(ListCategories))
            {
               var result =  MessageBox.Show("är du veeeerkligen säker på att du vill radera följande kategori: " + ListCategories.Text + "?", "bekräfta ",
                    MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    logikLager.remove(ListCategories.Text);
                    kategoriCb.Items.Clear();
                    ClearAll();
                    _categories = xmlHanterare.GetAllCategories();
                    MessageBox.Show("kategori väck wow, hihi!!!");
                    FillCategorylist();

                }
            }
        }

        private void bt_changePodLocation_Click(object sender, EventArgs e)
        {
            if(Validering.comboBoxNotEmpty(kategoriCb,ListCategories) )
            {
                if(ListPodcasts.SelectedItem == null )

                {
                    MessageBox.Show("var vänlig välj en pod att flytta");
                }
                else
                {
                    var result = MessageBox.Show("är du säker på att du vill ändra poddens location?", "bekräfta",
                        MessageBoxButtons.YesNo);
                      if (result == DialogResult.Yes)
                    {
                        logikLager.changePodcastLocation(ListCategories.Text, kategoriCb.Text, ListPodcasts.Text, kategoriCb);
                        ClearAll();
                        kategoriCb.Items.Clear();
                        _categories = xmlHanterare.GetAllCategories();
                        FillCategorylist();

                    }



                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(Validering.textFieldNotEmpty(laggTillKategoriCb, "text field"))
                { 
                    if(kategoriCb.SelectedItem == null)
                    {
                        MessageBox.Show("var vänlig och välj en kategori i comboboxen ovan");
                    }
                    else
                    {
                    var resultat = MessageBox.Show("är du säker på att du vill ändra namnet på podden?", "bekräfta",
                        MessageBoxButtons.YesNo);
                    if(resultat == DialogResult.Yes)
                        {
                        logikLager.changeCategory(kategoriCb.Text, laggTillKategoriCb.Text, ListCategories, kategoriCb);
                        MessageBox.Show("ändrad");
                        ClearAll();
                        kategoriCb.Items.Clear();
                        _categories = xmlHanterare.GetAllCategories();
                        FillCategorylist();
                        }
                    }
                }
        }

        private void bt_newPodName_Click(object sender, EventArgs e)
        {
            if (Validering.textFieldNotEmpty(namnField, "namnfält"))
            {
                if (ListPodcasts.SelectedItem == null)
                {
                    MessageBox.Show("var vänlig och välj en podcast från en kategori för att ändra dess nman Name.");
                    return;
                }
                else
                {
                    var resultat = MessageBox.Show("Äru säker på att du vill ändra namnet på podden?", "bekräfta",
                    MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes)
                    {
                        var pod = ListPodcasts.SelectedItem as Podcast;
                        
                        XmlHanterare xml = new XmlHanterare();
                        logikLager.remove(ListCategories.Text, ListPodcasts.Text);
                        var path = Directory.GetCurrentDirectory() + @"\" + kategoriCb.Text + @"\" + namnField.Text + ".xml";
                        xmlHanterare.AddNew(namnField.Text, path, ListCategories.Text, pod.UpdateInterval, pod.RssUrl);
                        ListCategories.Items.Clear();
                        ListEpisodes.Items.Clear();
                        ListPodcasts.Items.Clear();

                        kategoriCb.Items.Clear();
                        
                        _categories = xmlHanterare.GetAllCategories();
                        FillCategorylist();
                    }

                }
            }
        }

        private void kategoriCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new formPopup();
            form.Show(this);
        }
    }
  }


