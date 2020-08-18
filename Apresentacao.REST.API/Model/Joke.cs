using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.REST.API.Model
{
    public class Joke
    {
        public Joke(string value)
        {
            Value = value;
            DiaGerado = DateTime.Now;
        }

        public string Value { get; set; }
        public DateTime DiaGerado { get; set; }
    }
}
