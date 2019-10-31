using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net;
using System.Threading;
using Interblocks;


namespace InterBlock.Helpers.Utilities
{
    public class HttpHelpers
    {
        public static string GetClientIp(HttpRequestMessage request)
        {
            //request = request ?? Request;

            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }
            else if (HttpContext.Current != null)
            {
                return HttpContext.Current.Request.UserHostAddress;
            }
            else
            {
                return null;
            }
        }
    }

    public class LogMetadata
    {
        public string RequestContentType { get; set; }
        public string RequestUri { get; set; }
        public string RequestMethod { get; set; }
        public DateTime? RequestTimestamp { get; set; }
        public string ResponseContentType { get; set; }
        public HttpStatusCode ResponseStatusCode { get; set; }
        public DateTime? ResponseTimestamp { get; set; }
    }

    public class CustomLogHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                var logMetadata = BuildRequestMetadata(request);
                var response = await base.SendAsync(request, cancellationToken);
                logMetadata = BuildResponseMetadata(logMetadata, response);
                await SendToLog(logMetadata);
                return response;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        private LogMetadata BuildRequestMetadata(HttpRequestMessage request)
        {
            LogMetadata log = new LogMetadata
            {
                RequestMethod = request.Method.Method,
                RequestTimestamp = DateTime.Now,
                RequestUri = request.RequestUri.ToString()
            };
            return log;
        }
        private LogMetadata BuildResponseMetadata(LogMetadata logMetadata, HttpResponseMessage response)
        {
            logMetadata.ResponseStatusCode = response.StatusCode;
            logMetadata.ResponseTimestamp = DateTime.Now;
            logMetadata.ResponseContentType = response.Content.Headers.ContentType.MediaType;
            return logMetadata;
        }
        private async Task<bool> SendToLog(LogMetadata logMetadata)
        {

            Logger.LogSubHeader("Incomming Request");
            Logger.LogInfo("Request From", logMetadata.RequestUri);
            Logger.LogInfo("Request Method", logMetadata.RequestMethod);
            Logger.LogInfo("Request Came On", logMetadata.RequestTimestamp.ToString());
            Logger.LogInfo("Response ContentType", logMetadata.ResponseContentType);
            Logger.LogInfo("Response Status", logMetadata.ResponseStatusCode.ToString());
            Logger.LogInfo("Response Sent On", logMetadata.ResponseTimestamp.ToString());
            Logger.LogSeparater("Request End");

            return true;
        }

    }

   

}
