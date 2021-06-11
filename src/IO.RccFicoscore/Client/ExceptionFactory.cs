using System;
using RestSharp;

namespace IO.RccFicoscore.Client
{
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
