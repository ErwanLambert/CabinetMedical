// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
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
    public class IntervenantExterne : Intervenant
    {
        private readonly string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervenantExterne"/> class.
        /// Constructeur de la classe IntervenantExterne.
        /// </summary>
        /// <param name="nom">nom de l'intervenant externe.</param>
        /// <param name="prenom">prénom de l'intervenant externe.</param>
        /// <param name="specialite">spécialité de l'intervenant externe.</param>
        /// <param name="adresse">adresse de l'intervenant externe.</param>
        /// <param name="tel">téléphone de l'intervenant externe.</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// Gets retourne la spécialité de l'intervenant externe.
        /// </summary>
        public string Specialite => this.specialite;

        /// <summary>
        /// Gets or Sets retourne ou définit l'adresse de l'intervenant externe.
        /// </summary>
        public string Adresse { get => this.adresse; set => this.adresse = value; }

        /// <summary>
        /// Gets or Sets retourne ou définit le téléphone de l'intervenant externe.
        /// </summary>
        public string Tel { get => this.tel; set => this.tel = value; }

        /// <summary>
        /// Sérialization d'un objet de la classe IntervenantExterne.
        /// </summary>
        /// <returns>retourne l'objet IntervenantExterne sérializé.</returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " + this.Tel;
        }
    }
}