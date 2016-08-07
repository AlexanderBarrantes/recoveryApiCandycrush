using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyApi.Entity
{
    public class Elemento
    {
        public enum Color
        {
            red,
            blue,
            yellow,
            orange,
            green,

        };

        public int id { set; get; }

        public Color color { set; get; }

    }
}