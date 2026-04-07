using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfinance_web_netcore_domain;
using myfinance_web_netcore_domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace myfinance_web_netcore.Models
{
    public class PlanoContaModel
    {
        public int? Id {get; set;}

        public string Descricao {get; set;}

        public string Tipo {get; set;}

        
    }
}