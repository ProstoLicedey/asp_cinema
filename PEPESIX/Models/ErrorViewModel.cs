using pitpm_pr1.Models;
using pitpm_pr1.Controllers;

namespace pitpm_pr1.Models

{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}