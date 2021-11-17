// <copyright file="TempException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabinetMedical.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// .
    /// </summary>
    internal class TempException
    {
        private string application;
        private string classeException;
        private DateTime dateException;
        private string messageException;
        private string userException;
        private string userMachine;

        /// <summary>
        /// Initializes a new instance of the <see cref="TempException"/> class.
        /// .
        /// </summary>
        /// <param name="classeException">Classes exception.</param>
        /// <param name="messageException">message.</param>
        /// <param name="userException">Exception.</param>
        /// <param name="userMachine">Machine.</param>
        public TempException(string classeException, string messageException, string userException, string userMachine)
        {
            this.Application = "Soins2021";
            this.ClasseException = classeException;
            this.DateException = DateTime.Now;
            this.messageException = messageException;
            this.userException = userException;
            this.userMachine = userMachine;
        }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public string Application { get => this.application; set => this.application = value; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public string ClasseException { get => this.classeException; set => this.classeException = value; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public DateTime DateException { get => this.dateException; set => this.dateException = value; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public string MessageException { get => this.messageException; set => this.messageException = value; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public string UserException { get => this.userException; set => this.userException = value; }

        /// <summary>
        /// Gets or sets .
        /// </summary>
        public string UserMachine { get => this.userMachine; set => this.userMachine = value; }

        /// <summary>
        /// GetExceptionJson.
        /// </summary>
        /// <returns>return.</returns>
        public string GetExceptionJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }
    }
}