﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld
{
    public interface FabriqueJeu
    {
        Joueur creerJoueur(String nom, Peuple peuple);

        Partie creerPartie(int nombreTour, Joueur j1, Joueur j2, StrategieCarte carte, List<Unite> listeUniteJoueur1, List<Unite> listeUniteJoueur2);

        StrategieCarte creerCarte(int strategy);
    }
}
