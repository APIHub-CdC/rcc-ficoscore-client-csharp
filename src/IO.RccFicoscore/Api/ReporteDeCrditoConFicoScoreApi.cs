using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.RccFicoscore.Client;
using IO.RccFicoscore.Model;

namespace IO.RccFicoscore.Api
{
    public interface IReporteDeCrditoConFicoScoreApi : IApiAccessor
    {
        #region Synchronous Operations
        Respuesta GetRC (string xApiKey, string username, string password,string xfullReport, PersonaPeticion request);
        ApiResponse<Respuesta> GetRCWithHttpInfo (string xApiKey, string username, string password,string xfullReport, PersonaPeticion request);
        #endregion Synchronous Operations
    }
    public partial class ReporteDeCrditoConFicoScoreApi : IReporteDeCrditoConFicoScoreApi
    {
        private IO.RccFicoscore.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
        public ReporteDeCrditoConFicoScoreApi(String basePath)
        {
            this.Configuration = new IO.RccFicoscore.Client.Configuration(basePath);
            ExceptionFactory = IO.RccFicoscore.Client.Configuration.DefaultExceptionFactory;
        }
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }
        public IO.RccFicoscore.Client.Configuration Configuration {get; set;}
        public IO.RccFicoscore.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
        public Respuesta GetRC (string xApiKey, string username, string password,string xfullReport, PersonaPeticion request)
        {
             ApiResponse<Respuesta> localVarResponse = GetRCWithHttpInfo(xApiKey, username, password,xfullReport, request);
             return localVarResponse.Data;
        }
        public ApiResponse< Respuesta > GetRCWithHttpInfo (string xApiKey, string username, string password,string xfullReport, PersonaPeticion request)
        {
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ReporteDeCrditoPerApi->GetRC");
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling ReporteDeCrditoPerApi->GetRC");
            if (password == null)
                throw new ApiException(400, "Missing required parameter 'password' when calling ReporteDeCrditoPerApi->GetRC");
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ReporteDeCrditoPerApi->GetRC");
            if (xfullReport == null)
                xfullReport ="true";

            var localVarPath = "";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey));
            if (xfullReport != null) localVarHeaderParams.Add("x-full-report", this.Configuration.ApiClient.ParameterToString(xfullReport));
            if (username != null) localVarHeaderParams.Add("username", this.Configuration.ApiClient.ParameterToString(username));
            if (password != null) localVarHeaderParams.Add("password", this.Configuration.ApiClient.ParameterToString(password));
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request);
            }
            else
            {
                localVarPostBody = request;
            }
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);
            int localVarStatusCode = (int) localVarResponse.StatusCode;
            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRC", localVarResponse);
                if (exception != null) throw exception;
            }
            return new ApiResponse<Respuesta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Respuesta) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Respuesta)));
        }
    }
}
