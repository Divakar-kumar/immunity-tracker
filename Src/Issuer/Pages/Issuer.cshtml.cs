using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Humanizer;

namespace AspNetCoreVerifiableCredentials.Pages
{
    public class IssuerModel : PageModel
    { protected readonly AppSettingsModel _appSettings;
        protected readonly List<Status> _statuses;
        public IssuerModel( IOptions<AppSettingsModel> appSettings, StatusHelper statusHelper)
        {
            _appSettings = appSettings.Value;
            _statuses = statusHelper.GetStatuses();
        }
        
        public List<SelectListItem> Statuses { get; set; }

        public void OnGet(string statusSelected)
        {
            if(!string.IsNullOrEmpty(statusSelected) && !_statuses.Any( x => x.Name.Equals(statusSelected, StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new Exception("Invalid status specified");
            }

            statusSelected = statusSelected ?? string.Empty;
            Statuses = new List<SelectListItem>();

            foreach(string status in _statuses.Select( x => x.Name))
            {
                Statuses.Add(new SelectListItem
                {
                    Value = status,
                    Text = status.Humanize(LetterCasing.Title),
                    Selected = status.ToLower() == statusSelected.ToLower()
                });
            }
        }
    }
}
