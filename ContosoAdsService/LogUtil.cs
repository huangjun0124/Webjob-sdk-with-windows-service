using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoAdsService
{
    class LogUtil
    {
        private LogUtil()
        {
            EventLog = new EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("ContosoAds"))
            {
                System.Diagnostics.EventLog.CreateEventSource("ContosoAds", "AdsLog");
            }
            EventLog.Source = "ContosoAds";
            EventLog.Log = "AdsLog";
        }

        private static LogUtil _instance;

        public static LogUtil Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new LogUtil();
                return _instance;
            }
        }
        private System.Diagnostics.EventLog EventLog;

        public void WriteLog(string message, EventLogEntryType logType = EventLogEntryType.Information)
        {
            EventLog.WriteEntry(message, logType);
        }
    }
}
