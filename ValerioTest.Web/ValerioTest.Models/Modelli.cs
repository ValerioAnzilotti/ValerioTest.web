using System;
using System.Collections.Generic;
using System.Text;
using dapper = Dapper.Contrib.Extensions;

namespace ValerioTest.Models

{   
    [dapper.Table("dbo.Tavola")] 
    public class Modelli              //Identifico la tabella del database
    {
                                      

        [dapper.Key]                   //Definisco le classi del mio modello ad oggetti
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime SentDate { get; set; }
        public string Message { get; set; }
    }
}