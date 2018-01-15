using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido_Main.Main.Detectors
{
    static class AlertHelper
    {
        public static bool PreviousAlert(FidoReturnValues lFidoReturnValues, string event_id, string event_time)
        {
            var isRunDirector = false;
            for (var j = 0; j < lFidoReturnValues.PreviousAlerts.Alerts.Rows.Count; j++)
            {
                if (lFidoReturnValues.PreviousAlerts.Alerts.Rows[j][6].ToString() != event_id) continue;
                if (Convert.ToDateTime(event_time) == Convert.ToDateTime(lFidoReturnValues.PreviousAlerts.Alerts.Rows[j][4].ToString()))
                {
                    isRunDirector = true;
                }
            }
            return isRunDirector;
        }
    }
}
