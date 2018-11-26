using ClassLibrary1.Entities;
using Data;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication8
{
    partial class Feeds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LaggTillUrlLbl = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.ValjKategorilbl = new System.Windows.Forms.Label();
            this.kategoriCb = new System.Windows.Forms.ComboBox();
            this.lyssnadePodslbl = new System.Windows.Forms.Label();
            this.sparaBtn = new System.Windows.Forms.Button();
            this.RaderaUrl = new System.Windows.Forms.Button();
            this.sparaNyUrlBtn = new System.Windows.Forms.Button();
            this.uppdateringLbl = new System.Windows.Forms.Label();
            this.uppdatIntervallCb = new System.Windows.Forms.ComboBox();
            this.laggTillNyUrlLbl = new System.Windows.Forms.Label();
            this.speladepodsLi = new System.Windows.Forms.ListBox();
            this.KategoriLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laggTillKategoriCb = new System.Windows.Forms.TextBox();
            this.laggTillNyKatBtn = new System.Windows.Forms.Button();
            this.ListEpisodes = new System.Windows.Forms.ListBox();
            this.ListPodcasts = new System.Windows.Forms.ListBox();
            this.ListCategories = new System.Windows.Forms.ListBox();
            this.namnField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayPodButton = new System.Windows.Forms.Button();
            this.update_updateInterval = new System.Windows.Forms.Button();
            this.bt_deleteCat = new System.Windows.Forms.Button();
            this.bt_changePodLocation = new System.Windows.Forms.Button();
            this.bt_changeCatName = new System.Windows.Forms.Button();
            this.bt_newPodName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaggTillUrlLbl
            // 
            this.LaggTillUrlLbl.AutoSize = true;
            this.LaggTillUrlLbl.Location = new System.Drawing.Point(811, 90);
            this.LaggTillUrlLbl.Name = "LaggTillUrlLbl";
            this.LaggTillUrlLbl.Size = new System.Drawing.Size(57, 13);
            this.LaggTillUrlLbl.TabIndex = 0;
            this.LaggTillUrlLbl.Text = "Lägg til Url";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(811, 108);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(128, 20);
            this.urlTextBox.TabIndex = 1;
            // 
            // ValjKategorilbl
            // 
            this.ValjKategorilbl.AutoSize = true;
            this.ValjKategorilbl.Location = new System.Drawing.Point(811, 37);
            this.ValjKategorilbl.Name = "ValjKategorilbl";
            this.ValjKategorilbl.Size = new System.Drawing.Size(65, 13);
            this.ValjKategorilbl.TabIndex = 4;
            this.ValjKategorilbl.Text = "Välj kategori";
            // 
            // kategoriCb
            // 
            this.kategoriCb.FormattingEnabled = true;
            this.kategoriCb.Location = new System.Drawing.Point(811, 53);
            this.kategoriCb.Name = "kategoriCb";
            this.kategoriCb.Size = new System.Drawing.Size(128, 21);
            this.kategoriCb.TabIndex = 5;
            this.kategoriCb.SelectedIndexChanged += new System.EventHandler(this.kategoriCb_SelectedIndexChanged);
            // 
            // lyssnadePodslbl
            // 
            this.lyssnadePodslbl.AutoSize = true;
            this.lyssnadePodslbl.Location = new System.Drawing.Point(379, 299);
            this.lyssnadePodslbl.Name = "lyssnadePodslbl";
            this.lyssnadePodslbl.Size = new System.Drawing.Size(113, 13);
            this.lyssnadePodslbl.TabIndex = 9;
            this.lyssnadePodslbl.Text = "Nyligen lyssnade Pods";
            // 
            // sparaBtn
            // 
            this.sparaBtn.Location = new System.Drawing.Point(812, 253);
            this.sparaBtn.Name = "sparaBtn";
            this.sparaBtn.Size = new System.Drawing.Size(127, 60);
            this.sparaBtn.TabIndex = 10;
            this.sparaBtn.Text = "Spara";
            this.sparaBtn.UseVisualStyleBackColor = true;
            this.sparaBtn.Click += new System.EventHandler(this.sparaBtn_Click);
            // 
            // RaderaUrl
            // 
            this.RaderaUrl.Location = new System.Drawing.Point(196, 319);
            this.RaderaUrl.Name = "RaderaUrl";
            this.RaderaUrl.Size = new System.Drawing.Size(140, 38);
            this.RaderaUrl.TabIndex = 14;
            this.RaderaUrl.Text = "Radera";
            this.RaderaUrl.UseVisualStyleBackColor = true;
            this.RaderaUrl.Click += new System.EventHandler(this.RaderaUrl_Click);
            // 
            // sparaNyUrlBtn
            // 
            this.sparaNyUrlBtn.Location = new System.Drawing.Point(12, 363);
            this.sparaNyUrlBtn.Name = "sparaNyUrlBtn";
            this.sparaNyUrlBtn.Size = new System.Drawing.Size(149, 47);
            this.sparaNyUrlBtn.TabIndex = 16;
            this.sparaNyUrlBtn.Text = "Spara Ny URL ";
            this.sparaNyUrlBtn.UseVisualStyleBackColor = true;
            this.sparaNyUrlBtn.Click += new System.EventHandler(this.sparaNyUrlBtn_Click);
            // 
            // uppdateringLbl
            // 
            this.uppdateringLbl.AutoSize = true;
            this.uppdateringLbl.Location = new System.Drawing.Point(811, 201);
            this.uppdateringLbl.Name = "uppdateringLbl";
            this.uppdateringLbl.Size = new System.Drawing.Size(106, 13);
            this.uppdateringLbl.TabIndex = 23;
            this.uppdateringLbl.Text = "Uppdateringsintervall";
            // 
            // uppdatIntervallCb
            // 
            this.uppdatIntervallCb.FormattingEnabled = true;
            this.uppdatIntervallCb.Location = new System.Drawing.Point(811, 217);
            this.uppdatIntervallCb.Name = "uppdatIntervallCb";
            this.uppdatIntervallCb.Size = new System.Drawing.Size(128, 21);
            this.uppdatIntervallCb.TabIndex = 24;
            // 
            // laggTillNyUrlLbl
            // 
            this.laggTillNyUrlLbl.AutoSize = true;
            this.laggTillNyUrlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laggTillNyUrlLbl.Location = new System.Drawing.Point(809, 9);
            this.laggTillNyUrlLbl.Name = "laggTillNyUrlLbl";
            this.laggTillNyUrlLbl.Size = new System.Drawing.Size(109, 16);
            this.laggTillNyUrlLbl.TabIndex = 30;
            this.laggTillNyUrlLbl.Text = "Lägg till en ny Url";
            // 
            // speladepodsLi
            // 
            this.speladepodsLi.FormattingEnabled = true;
            this.speladepodsLi.Location = new System.Drawing.Point(382, 315);
            this.speladepodsLi.Name = "speladepodsLi";
            this.speladepodsLi.Size = new System.Drawing.Size(145, 95);
            this.speladepodsLi.TabIndex = 31;
            // 
            // KategoriLbl
            // 
            this.KategoriLbl.AutoSize = true;
            this.KategoriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriLbl.Location = new System.Drawing.Point(559, 12);
            this.KategoriLbl.Name = "KategoriLbl";
            this.KategoriLbl.Size = new System.Drawing.Size(70, 16);
            this.KategoriLbl.TabIndex = 32;
            this.KategoriLbl.Text = "Kategorier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lägg till en ny kategori";
            // 
            // laggTillKategoriCb
            // 
            this.laggTillKategoriCb.Location = new System.Drawing.Point(562, 57);
            this.laggTillKategoriCb.Name = "laggTillKategoriCb";
            this.laggTillKategoriCb.Size = new System.Drawing.Size(124, 20);
            this.laggTillKategoriCb.TabIndex = 39;
            // 
            // laggTillNyKatBtn
            // 
            this.laggTillNyKatBtn.Location = new System.Drawing.Point(562, 83);
            this.laggTillNyKatBtn.Name = "laggTillNyKatBtn";
            this.laggTillNyKatBtn.Size = new System.Drawing.Size(124, 41);
            this.laggTillNyKatBtn.TabIndex = 40;
            this.laggTillNyKatBtn.Text = "Lägg till ";
            this.laggTillNyKatBtn.UseVisualStyleBackColor = true;
            this.laggTillNyKatBtn.Click += new System.EventHandler(this.laggTillNyKatBtn_Click);
            // 
            // ListEpisodes
            // 
            this.ListEpisodes.FormattingEnabled = true;
            this.ListEpisodes.Location = new System.Drawing.Point(382, 12);
            this.ListEpisodes.Name = "ListEpisodes";
            this.ListEpisodes.Size = new System.Drawing.Size(145, 212);
            this.ListEpisodes.TabIndex = 42;
            this.ListEpisodes.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ListPodcasts
            // 
            this.ListPodcasts.FormattingEnabled = true;
            this.ListPodcasts.Location = new System.Drawing.Point(196, 12);
            this.ListPodcasts.Name = "ListPodcasts";
            this.ListPodcasts.Size = new System.Drawing.Size(140, 212);
            this.ListPodcasts.TabIndex = 43;
            this.ListPodcasts.SelectedIndexChanged += new System.EventHandler(this.ListPodcasts_SelectedIndexChanged);
            // 
            // ListCategories
            // 
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.Location = new System.Drawing.Point(12, 12);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(149, 212);
            this.ListCategories.TabIndex = 44;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            // 
            // namnField
            // 
            this.namnField.Location = new System.Drawing.Point(811, 165);
            this.namnField.Name = "namnField";
            this.namnField.Size = new System.Drawing.Size(128, 20);
            this.namnField.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Namn på pod";
            // 
            // PlayPodButton
            // 
            this.PlayPodButton.Location = new System.Drawing.Point(382, 230);
            this.PlayPodButton.Name = "PlayPodButton";
            this.PlayPodButton.Size = new System.Drawing.Size(145, 40);
            this.PlayPodButton.TabIndex = 47;
            this.PlayPodButton.Text = "Spela Pod";
            this.PlayPodButton.UseVisualStyleBackColor = true;
            this.PlayPodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_updateInterval
            // 
            this.update_updateInterval.Location = new System.Drawing.Point(12, 319);
            this.update_updateInterval.Name = "update_updateInterval";
            this.update_updateInterval.Size = new System.Drawing.Size(149, 38);
            this.update_updateInterval.TabIndex = 49;
            this.update_updateInterval.Text = "Update update interval";
            this.update_updateInterval.UseVisualStyleBackColor = true;
            this.update_updateInterval.Click += new System.EventHandler(this.update_updateInterval_Click);
            // 
            // bt_deleteCat
            // 
            this.bt_deleteCat.Location = new System.Drawing.Point(12, 230);
            this.bt_deleteCat.Name = "bt_deleteCat";
            this.bt_deleteCat.Size = new System.Drawing.Size(149, 40);
            this.bt_deleteCat.TabIndex = 50;
            this.bt_deleteCat.Text = "radera kategori";
            this.bt_deleteCat.UseVisualStyleBackColor = true;
            this.bt_deleteCat.Click += new System.EventHandler(this.bt_deleteCat_Click);
            // 
            // bt_changePodLocation
            // 
            this.bt_changePodLocation.Location = new System.Drawing.Point(196, 276);
            this.bt_changePodLocation.Name = "bt_changePodLocation";
            this.bt_changePodLocation.Size = new System.Drawing.Size(140, 37);
            this.bt_changePodLocation.TabIndex = 51;
            this.bt_changePodLocation.Text = "Byt pod Location";
            this.bt_changePodLocation.UseVisualStyleBackColor = true;
            this.bt_changePodLocation.Click += new System.EventHandler(this.bt_changePodLocation_Click);
            // 
            // bt_changeCatName
            // 
            this.bt_changeCatName.Location = new System.Drawing.Point(12, 276);
            this.bt_changeCatName.Name = "bt_changeCatName";
            this.bt_changeCatName.Size = new System.Drawing.Size(149, 37);
            this.bt_changeCatName.TabIndex = 52;
            this.bt_changeCatName.Text = "byt namn på kategori";
            this.bt_changeCatName.UseVisualStyleBackColor = true;
            this.bt_changeCatName.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bt_newPodName
            // 
            this.bt_newPodName.Location = new System.Drawing.Point(196, 230);
            this.bt_newPodName.Name = "bt_newPodName";
            this.bt_newPodName.Size = new System.Drawing.Size(140, 40);
            this.bt_newPodName.TabIndex = 53;
            this.bt_newPodName.Text = "byt namn på pod 2";
            this.bt_newPodName.UseVisualStyleBackColor = true;
            this.bt_newPodName.Click += new System.EventHandler(this.bt_newPodName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "bt_popupWindow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Feeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_newPodName);
            this.Controls.Add(this.bt_changeCatName);
            this.Controls.Add(this.bt_changePodLocation);
            this.Controls.Add(this.bt_deleteCat);
            this.Controls.Add(this.update_updateInterval);
            this.Controls.Add(this.PlayPodButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namnField);
            this.Controls.Add(this.ListCategories);
            this.Controls.Add(this.ListPodcasts);
            this.Controls.Add(this.ListEpisodes);
            this.Controls.Add(this.laggTillNyKatBtn);
            this.Controls.Add(this.laggTillKategoriCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KategoriLbl);
            this.Controls.Add(this.speladepodsLi);
            this.Controls.Add(this.laggTillNyUrlLbl);
            this.Controls.Add(this.uppdatIntervallCb);
            this.Controls.Add(this.uppdateringLbl);
            this.Controls.Add(this.sparaNyUrlBtn);
            this.Controls.Add(this.RaderaUrl);
            this.Controls.Add(this.sparaBtn);
            this.Controls.Add(this.lyssnadePodslbl);
            this.Controls.Add(this.kategoriCb);
            this.Controls.Add(this.ValjKategorilbl);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.LaggTillUrlLbl);
            this.Name = "Feeds";
            this.Text = "Feeds";
            this.Load += new System.EventHandler(this.Feeds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaggTillUrlLbl;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label ValjKategorilbl;
        private System.Windows.Forms.ComboBox kategoriCb;
        private System.Windows.Forms.Label lyssnadePodslbl;
        private System.Windows.Forms.Button sparaBtn;
        private System.Windows.Forms.Button RaderaUrl;
        private System.Windows.Forms.Button sparaNyUrlBtn;
        private System.Windows.Forms.Label uppdateringLbl;
        private System.Windows.Forms.ComboBox uppdatIntervallCb;
        private System.Windows.Forms.Label laggTillNyUrlLbl;
        private System.Windows.Forms.ListBox speladepodsLi;
        private System.Windows.Forms.Label KategoriLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox laggTillKategoriCb;
        private System.Windows.Forms.Button laggTillNyKatBtn;
        private System.Windows.Forms.ListBox ListEpisodes;
        private System.Windows.Forms.ListBox ListPodcasts;
        private System.Windows.Forms.ListBox ListCategories;
        private System.Windows.Forms.TextBox namnField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlayPodButton;
        private System.Windows.Forms.Button update_updateInterval;
        private System.Windows.Forms.Button bt_deleteCat;
        private System.Windows.Forms.Button bt_changePodLocation;
        private System.Windows.Forms.Button bt_changeCatName;
        private System.Windows.Forms.Button bt_newPodName;
        private System.Windows.Forms.Button button1;

        //public EventHandler urlTextBox_TextChanged { get; private set; }
    }
}