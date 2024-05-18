using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ListeTache.Models;
namespace ListeTache.Pages
{
    public class Index1Model : PageModel
    {
        public IList<Models.Tache> Tasks { get; set; }

        public void OnGet()
        {
            Tasks = new List<Models.Tache>
            {
                new Models.Tache { TacheId = 1, Titre = "T�che 1", TacheTerminee = false },
                new Models.Tache { TacheId = 2, Titre = "T�che 2", TacheTerminee = true },
                new Models.Tache { TacheId = 3, Titre = "T�che 3", TacheTerminee = false }
            };
        }
    }
}
