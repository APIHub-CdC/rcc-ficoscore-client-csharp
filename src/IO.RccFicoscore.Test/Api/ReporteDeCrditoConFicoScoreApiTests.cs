using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;using IO.RccFicoscore.Client;
using IO.RccFicoscore.Api;
using IO.RccFicoscore.Model;

namespace IO.RccFicoscore.Test
{
    [TestFixture]
    public class ReporteDeCrditoConFicoScoreApiTests
    {
        private string xApiKey;
        private string username;
        private string password;

        private ReporteDeCrditoConFicoScoreApi api;
        [SetUp]
        public void Init()
        {
            string basePath = "the_url/v2/rccficoscore";
            this.xApiKey = "the_url";
            this.username = "your_username";
            this.password = "your_passwords";
            this.api = new ReporteDeCrditoConFicoScoreApi(basePath);
        }

        [Test]
        public void GetReporteTest()
        {
            var xfullReport = "true";

            PersonaPeticion request = new PersonaPeticion();
            DomicilioPeticion domicilio = new DomicilioPeticion();
            

            request.ApellidoPaterno ="LLLLLLLL";
            request.ApellidoMaterno ="LLLLLLLL";
            request.PrimerNombre ="LLLLLLLLL";
            request.FechaNacimiento ="NNNN-NN-NN";
            request.RFC ="LLLLNNNNNN";
            request.Nacionalidad ="LL";
  
            domicilio.Direccion = "LLLLLLLL LL";
            domicilio.ColoniaPoblacion = "LLLLL";
            domicilio.DelegacionMunicipio = "LLLLLLL";
            domicilio.Ciudad = "LLLLLLLLLL";
            domicilio.Estado = CatalogoEstados.CDMX;
            domicilio.CP = "NNNNN";
            domicilio.FechaResidencia = "NNNN-NN-NN";
            domicilio.TipoDomicilio = CatalogoTipoDomicilio.C;
            domicilio.TipoAsentamiento = CatalogoTipoAsentamiento._28;


            request.Domicilio = domicilio;


            var response =this.api.GetRC( this.xApiKey, this.username, this.password,xfullReport, request );
            Assert.IsInstanceOf<Respuesta> (response, "response is Respuesta");
            Console.WriteLine(response.ToJson());

        }
        
    }
}
