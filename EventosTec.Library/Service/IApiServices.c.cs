using EventosTec.Library.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Library.Service
{
    public interface IApiServices
    {
        Task<Response> GetTokenAsync(string urlBase,
            string servicePrefix, string controller, TokenRequest request);
        
    }

  
}
