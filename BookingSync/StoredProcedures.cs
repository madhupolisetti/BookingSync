using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSync
{
    public static class StoredProcedures
    {
        public const string GET_UNSYNCED_SEATING_CHART = "GetUnSyncedSeatingChart";
        public const string GET_UNSYNCED_SCHEDULES = "GetUnSyncedSchedules";
        public const string GET_MOVIES_TO_SYNC = "GetMoviesToSync";
        public const string UPDATE_SERVICE_STATUS = "UpdateServiceStatus";
    }
}
