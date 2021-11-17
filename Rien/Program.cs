// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Rien
{
    using System;
    using CabinetMedical.Exceptions;

    /// <summary>
    /// Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">args.</param>
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                throw new CabinetMedicalException("message");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
