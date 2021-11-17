// <copyright file="Prestation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabinetMedical.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// .
    /// </summary>
    public class Prestation
    {
        private readonly string libelle;
        private readonly DateTime dateHeureSoin;
        private Intervenant intervenant;

        /// <summary>
        /// Initializes a new instance of the <see cref="Prestation"/> class.
        /// Constructeur.
        /// </summary>
        /// <param name="libelle">libelle.</param>
        /// <param name="dateHeure">date heure.</param>
        /// <param name="intervenant">intervenant.</param>
        public Prestation(string libelle, DateTime dateHeure, Intervenant intervenant)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeure;
            this.intervenant = intervenant;
        }

        /// <summary>
        /// Gets property du libelle de la prestation (lecture seule).
        /// </summary>
        public string Libelle => this.libelle;

        /// <summary>
        /// Gets property de la date des soins (lecture seule).
        /// </summary>
        public DateTime DateHeureSoin => this.dateHeureSoin;

        /// <summary>
        /// Gets property de l'objet intervenant ayant réalisé la prestation
        /// (lecture seule).
        /// </summary>
        public Intervenant Intervenant => this.intervenant;

        /// <summary>
        /// .
        /// </summary>
        /// <returns>blablabla.</returns>
        public string HeureSoin()
        {
            return this.DateHeureSoin.Hour + "h" + this.DateHeureSoin.Minute + " - " + this.DateHeureSoin.ToShortTimeString();
        }

        /// <summary>
        /// fonction qui compare 2 dates au format DateHeure
        /// Attention ici, on ne compare que les dates.
        /// 2 dates seront égales si leur JJ/MM/AAAA  sont égaux, quelle que soit l'heure.
        /// </summary>
        /// <param name="unePrestation">une prestation.</param>
        /// <returns>
        ///     0 les dates sont égales
        ///     1 si la date de la prestation courante est postérieure à la date de la prestation unePrestation
        ///     -1 si la date de la prestation courante est antérieure à la date de la prestation unePrestation.
        /// </returns>
        public int CompareTo(Prestation unePrestation)
        {
            // if(this.DateHeureSoin.Date > unePrestation.DateHeureSoin.Date) {
            //    return 1;
            // }
            // else
            // {
            //    if (this.DateHeureSoin.Date == unePrestation.DateHeureSoin.Date)
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        return -1;
            //    }
            // }
            // bien mieux car on utilise le framework
            return this.DateHeureSoin.Date.CompareTo(unePrestation.DateHeureSoin.Date);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "\t" + this.libelle + " - " + this.dateHeureSoin.ToString() + " - " + this.intervenant;
        }
    }
}