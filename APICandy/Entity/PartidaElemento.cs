using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyApi.Entity
{
    public class PartidaElemento
    {
        public Partida partida { set; get; }

        public List<Elemento> elements { set; get; }
    }
}