using MPM_CR_TSM.Models;
using MPM_CR_TSM.MPM_TSMNewSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web.Http;

namespace MPM_CR_TSM.Controllers
{
    public class workingTimeController : ApiController
    {
        // GET api/workingtimes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/workingtimes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/workingtimes
        public getRuleOT_WFHResponse Post([FromBody] parmModel value)
        {
            CallContext Context = new CallContext();
            var aosUriString = ClientConfiguration.Default.UriString;

            var serviceUriString = SoapHelper.GetSoapServiceUriString("MPM_TSMNew", aosUriString);

            var endpointAddress = new EndpointAddress(serviceUriString);
            var binding = SoapHelper.GetBinding();

            var client = new MPM_TSMNew_SvcCntrClient(binding, endpointAddress);
            var channel = client.InnerChannel;

            getRuleOT_WFHResponse _List = new getRuleOT_WFHResponse { };

            Context.Company = value.cmpny;

            var request = new getRuleOT_WFH()
            {
                CallContext = Context,
                DriverCode = value.driverCode,
                typeOfWork = value.typeOfWork
            };

            try
            {
                using (OperationContextScope operationContextScope = new OperationContextScope(channel))
                {
                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers[OAuthHelper.OAuthHeader] = OAuthHelper.GetAuthenticationHeader(true);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                     //client.ClientCredentials.Windows.ClientCredential.UserName = "MPM-RENT\\AxAdmine";
                     //client.ClientCredentials.Windows.ClientCredential.UserName = "!3$1%MpM_(=^*";

                    _List = ((MPM_TSMNew_SvcCntr)channel).getRuleOT_WFH(request);

                    client.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return _List;
        }

        // PUT api/workingtimes/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/workingtimes/5
        public void Delete(int id)
        {
        }
    }
}
