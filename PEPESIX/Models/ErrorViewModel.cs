using pitpm_pr1.Models;
using pitpm_pr1.Controllers;

namespace pitpm_pr1.Models

{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
        public int user_id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public long phone_numb { get; set; }
        public Nullable<System.DateTime> date_birthday { get; set; }
        public string password { get; set; }
        public bool admin_check { get; set; }

    }
}