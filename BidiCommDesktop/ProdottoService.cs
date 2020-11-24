using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidiCommDesktop
{
    public interface IProdottoService
    {
        Task<string> Calcola(string payload);
    }

    public class ProdottoService
        : IProdottoService
    {
        async Task<string> IProdottoService.Calcola(string payload)
        {
            var jinput = JObject.Parse(payload);
            var a = (double)jinput["a"];
            var b = (double)jinput["b"];

            await Task.Delay(1000); //simula impegno

            var joutput = new JObject()
            {
                ["result"] = a * b,
            };
            return joutput.ToString();
        }
    }
}
