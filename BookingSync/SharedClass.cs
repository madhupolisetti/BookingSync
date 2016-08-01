using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace BookingSync
{
    class SharedClass
    {
        #region PRIVATE VARIABLES
        private static string _connectionString = string.Empty;
        private static ILog _logger = null;
        private static bool _hasStopSignal = true;
        private static bool _isServiceCleaned = true;
        private static byte _notifyMaxFailedAttempts = 0;
        private static string _notifyAuthUserName = string.Empty;
        private static string _notifyAuthPassword = string.Empty;
        private static int _seatSyncIntervalInSeconds = 120;
        private static int _scheduleSyncIntervalInSeconds = 600;
        private static int _releaseCheckIntervalInSeconds = 120;
        #endregion
        public static void InitializeLogger()
        {
            GlobalContext.Properties["LogName"] = DateTime.Now.ToString("yyyyMMdd");
            log4net.Config.XmlConfigurator.Configure();
            _logger = LogManager.GetLogger("Log");
        }
        #region PROPERTIES
        public static string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
        public static ILog Logger
        {
            get { return _logger; }
            set { _logger = value; }
        }
        public static bool HasStopSignal
        {
            get { return _hasStopSignal; }
            set { _hasStopSignal = value; }
        }
        public static bool IsServiceCleaned
        {
            get { return _isServiceCleaned; }
            set { _isServiceCleaned = value; }
        }
        public static byte NotifyMaxFailedAttempts
        {
            get { return _notifyMaxFailedAttempts; }
            set { _notifyMaxFailedAttempts = value; }
        }
        public static string NotifyAuthUserName
        {
            get { return _notifyAuthUserName; }
            set { _notifyAuthUserName = value; }
        }
        public static string NotifyAuthPassword
        {
            get { return _notifyAuthPassword; }
            set { _notifyAuthPassword = value; }
        }
        public static int SeatSyncIntervalInSeconds
        {
            get { return _seatSyncIntervalInSeconds; }
            set { _seatSyncIntervalInSeconds = value; }
        }
        public static int ScheduleSyncIntervalInSeconds
        {
            get { return _scheduleSyncIntervalInSeconds; }
            set { _scheduleSyncIntervalInSeconds = value; }
        }
        public static int ReleaseCheckIntervalInSeconds
        {
            get { return _releaseCheckIntervalInSeconds; }
            set { _releaseCheckIntervalInSeconds = value; }
        }
        #endregion
    }
}
