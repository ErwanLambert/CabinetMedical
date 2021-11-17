// <copyright file="DossierTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestCabinetMedical
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CabinetMedical.ClassesMetier;
    using CabinetMedical.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// .
    /// </summary>
    [TestClass]
    public class DossierTest
    {
        /// <summary>
        /// .
        /// </summary>
        [TestMethod]
        public void TesteGetNbPrestationsI()
        {
            Intervenant intervenant = new Intervenant("Dupont", "Pierre");
            intervenant.AjoutePrestation(new Prestation("Presta 10", new DateTime(2019, 6, 12), intervenant));
            intervenant.AjoutePrestation(new Prestation("Presta 11", new DateTime(2019, 6, 15), intervenant));
            Assert.AreEqual(2, intervenant.GetNbPrestations());
        }

        /// <summary>
        /// .
        /// </summary>
        [TestMethod]
        public void TesteGetNbPrestationsIE()
        {
            IntervenantExterne intervenantExterne = new IntervenantExterne("Benoit", "Michel", "Radiologue", "Sous le pont d'Avignon", "6669996969");
            intervenantExterne.AjoutePrestation(new Prestation("Presta 12", new DateTime(2019, 6, 16), intervenantExterne));
            intervenantExterne.AjoutePrestation(new Prestation("Presta 13", new DateTime(2019, 6, 18), intervenantExterne));
            Assert.AreEqual(2, intervenantExterne.GetNbPrestations());
        }

        /// <summary>
        /// .
        /// </summary>
        [TestMethod]
        public void TestDateCreationDossierOK()
        {
            Dossier dossier = new Dossier("Dupont", "Jean", new DateTime(1990, 11, 12), new DateTime(2019, 3, 31));
            Assert.IsInstanceOfType(dossier, typeof(Dossier));
        }

        /// <summary>
        /// .
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CabinetMedicalException))]
        public void TestDateCreationDossierKO()
        {
            DateTime dateCreationDossier = DateTime.Now.AddDays(10);
            Dossier dossier = new Dossier("Dupont", "Jean", dateCreationDossier, new DateTime(2019, 3, 31));
        }
    }
}
