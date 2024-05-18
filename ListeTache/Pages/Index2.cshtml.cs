using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ListeTache.Pages
{
    public class Index2Model : PageModel
    {
        private const int NombreMaximumDeTentatives = 5;
        private readonly Random _random = new Random();

        public int TentativesRestantes { get; private set; }
        public string Message { get; private set; }
        public bool GameOver { get; private set; }
        public string Resultat { get; private set; }
        public int NombreAleatoire { get; private set; }

        public void OnGet()
        {
            // Générer un nombre aléatoire entre 0 et 100
            NombreAleatoire = _random.Next(101);
            TentativesRestantes = NombreMaximumDeTentatives;
        }

        public IActionResult OnPost(int guess, int tentativesRestantes)
        {
            TentativesRestantes = tentativesRestantes - 1;

            if (guess == NombreAleatoire)
            {
                Resultat = "Bravo, vous avez deviné le nombre correctement!";
                GameOver = true;
                return Page();
            }

            if (TentativesRestantes == 0)
            {
                Resultat = "Désolé, vous avez épuisé toutes vos tentatives. Le nombre était " + NombreAleatoire + ".";
                GameOver = true;
                return Page();
            }

            if (guess > NombreAleatoire)
            {
                Message = "Trop grand";
            }
            else
            {
                Message = "Trop petit";
            }

            return Page();
        }
    }
}
s