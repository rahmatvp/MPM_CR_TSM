using MPM_CR_TSM.Models;
using MPM_CR_TSM.MPM_TSMNewSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MPM_CR_TSM.Controllers
{
    public class TSMProcessController : ApiController
    {
        // GET api/TSMProcess
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public postTSMAbsenDriverResponse Post([FromBody] parmModel value)
        //public MPM_TSMNew_Temp[] Post([FromBody] parmModel value)
        {
            CallContext Context = new CallContext();
            var aosUriString = ClientConfiguration.Default.UriString;

            var serviceUriString = SoapHelper.GetSoapServiceUriString("MPM_TSMNew", aosUriString);

            var endpointAddress = new EndpointAddress(serviceUriString);
            var binding = SoapHelper.GetBinding();

            var client = new MPM_TSMNew_SvcCntrClient(binding, endpointAddress);
            var channel = client.InnerChannel;

            postTSMAbsenDriverResponse _List = new postTSMAbsenDriverResponse{};
            //MPM_TSMNew_Temp[] _List = new MPM_TSMNew_Temp[] { };

            Context.Company = value.cmpny;

            var request = new postTSMAbsenDriver()
            {
                CallContext = Context,
                TransID = value.transId,
                DriverCode = value.driverCode,
                DriverName = value.driverName,
                CheckInDateTime = value.checkInDateTime,
                CheckOutDateTime = value.checkOutDateTime,
                CustId = value.custId,
                CustName = value.custName,
                Notes = value.notes,
                UsageKMStart = value.usageKMStart,
                UsageKMEnd = value.usageKMEnd,
                OutOfTown = value.outOfTown,
                Town_City = value.town_city,
                Nopol = value.nopol,
                TempDriverCode = value.tempDriverCode,
                typeOfUse = value.typeOfUse,
                approvedBy = value.approvedBy,
                ApprovedDateTime = value.approvedDateTime,
                Scoring = value.scoring,
                PICName = value.picName,
                approvalType = value.approvalType,
                typeOfWork = value.typeOfWork
            };

            try
            {
                using (OperationContextScope operationContextScope = new OperationContextScope(channel))
                {
                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers[OAuthHelper.OAuthHeader] = OAuthHelper.GetAuthenticationHeader(true);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                    _List = ((MPM_TSMNew_SvcCntr)channel).postTSMAbsenDriver(request);

                    client.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return _List;
        }
    }

}