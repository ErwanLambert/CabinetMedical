// <copyright file="CabinetMedicalException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabinetMedical.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using System.Xml;

    // using Newtonsoft.Json;

    /// <summary>
    /// Classe SoinException hérité de la classe Exception.
    /// </summary>
    public class CabinetMedicalException : Exception
    {
        // private static string jsonLog;

        /// <summary>
        /// Initializes a new instance of the <see cref="CabinetMedicalException"/> class.
        /// </summary>
        /// <param name="message">Message d'Excpeption.</param>
        public CabinetMedicalException(string message)
            : base(message)
        {
            // var log = new Dictionary<string, string>
            // {
            //    { "Soins2021 ", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() },
            //    { "ClasseException ", this.GetType().Name.ToString() },
            //    { "DateException ", DateTime.Now.ToString() },
            //    { "MessageException ", this.Message },
            //    { "UserException ", Environment.UserName },
            //    { "UserMachine ", Environment.MachineName },
            // };
            TempException log = new TempException("SoinException", message, Environment.UserName.ToString(), Environment.MachineName.ToString());
            var options = new JsonSerializerOptions { WriteIndented = true };

            // SoinException.jsonLog = JsonConvert.SerializeObject(log,Formatting.Indented);
            string jsonLog = JsonSerializer.Serialize(log, options);

            // evo filestream
            // ListEx.Add(log);
            string filePath = @"F:\Bonaparte\Roche\C#\TP1 - Prestations Soins\CabinetMedical\CabinetMedical\CabinetMedical\ExceptionData.json";
            List<TempException> lesExceptionsContenuesDansLeFichier = JsonSerializer.Deserialize<List<TempException>>(filePath);
            lesExceptionsContenuesDansLeFichier.Add(log);
            string logs = JsonSerializer.Serialize(lesExceptionsContenuesDansLeFichier, options);
            File.WriteAllText(filePath, logs);

            // File.AppendAllText(filePath, jsonLog);
        }

        /// <summary>
        /// Gets or sets getter et Setter de la liste d'Exception de la classe ExceptionSoin.
        /// </summary>
        public static List<Dictionary<string, string>> ListEx { get; set; } = new List<Dictionary<string, string>>();

        /// <summary>
        /// Gets or sets getter et Setter massage Exception.
        /// </summary>
        public string Message1 { get; set; }

        /// <summary>
        /// Méthode pour journalisation des exception de la classe ExceptionSoins.
        /// </summary>
        public static void Log()
        {
            string logJson = JsonSerializer.Serialize(ListEx);
            string filePath = @"E:\Roche\TP C# 2a\Soins2021\Soins2021\ExceptionData.json";
            File.AppendAllText(filePath, logJson);
            string contenu = File.ReadAllText(filePath);
            contenu = contenu.Replace("][", string.Empty);
            File.WriteAllText(filePath, contenu);
        }
    }
}