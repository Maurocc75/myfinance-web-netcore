using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;



namespace myfinance_web_netcore_domain.Entities
{
    public class PlanoConta
    {
        public int? Id { get; set;}
        
        public string Descricao { get; set; }

        public string Tipo { get; set;} 
           
    }
}