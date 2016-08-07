using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyApi.Entity
{
    public class Partida
    {
        public int id { set; get; }

        public List<Elemento> elementos { set; get; }
    }
}