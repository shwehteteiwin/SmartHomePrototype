using Newtonsoft.Json;
using static SmartHomeSideMenubar.DBQuery.DbDevicesHelper;

namespace SmartHomeSideMenubar
{
    public class Device
    {
        public int DeviceID { get; set; }
        public int Id { get; set; } 
        public string DeviceName { get; set; }
        public string TypeName { get; set; }  // Ensure this exists
        public DeviceStatus Status { get; set; }    // Ensure this is a string
        public bool IsReal { get; set; }
        public string GroupName { get; set; } // Ensure this exists
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        // ✅ Converts enum to string for DataGridView
        public string StatusText => Status.ToString();

        // ✅ Converts bool to "Yes" / "No"
        public string AdjustableText => IsReal ? "Yes" : "No";

        public object TypeID { get; internal set; }
        public object GroupID { get; internal set; }
        public string Name { get; internal set; }

        public string GeneratePayload(string command, int? value = null)
        {
            var payload = new { action = command, value = value };
            return JsonConvert.SerializeObject(payload);
        }
    }
}


