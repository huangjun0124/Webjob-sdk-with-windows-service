using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace ContosoAdsService
{
    public partial class ContosoAds : ServiceBase
    {
        public ContosoAds()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Set up a timer to trigger every minute.  
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 12000; // 1 seconds  
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
            LogUtil.Instance.WriteLog("ContosoAds service started...");
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            (sender as System.Timers.Timer).Stop();
            LogUtil.Instance.WriteLog("JobHost run and block");
            JobHost host = new JobHost();
            host.RunAndBlock();
        }

        protected override void OnStop()
        {
            LogUtil.Instance.WriteLog("ContosoAds service stopped...");
        }
    }
}
