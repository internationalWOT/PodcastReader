using ClassLibrary1.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;


namespace Logik.Service
{
    public class TimerService
    {
        private static System.Timers.Timer timer;
        public XmlHanterare xmlhanterare;
        public LogikLager logiklager;

        private Podcast podcast;
        private string podcastName;
        private string categoryName;
        private string url;



        public TimerService()
        {            
            timer = new System.Timers.Timer();
            logiklager = new LogikLager();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);

            logiklager = new LogikLager();
            xmlhanterare = new XmlHanterare();
        }

        public void queueNewUpdate(string podcastName, string categoryName, Podcast podcastToUpdate, string url)
        {
            podcast = podcastToUpdate;
            this.podcastName = podcastName;
            this.categoryName = categoryName;
            this.url = url;

            timer.Interval = podcast.UpdateInterval;
            timer.Enabled = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
           
            xmlhanterare.AddNew(podcastName, podcast.Path, categoryName, podcast.UpdateInterval, url);
            
        }
    }
}