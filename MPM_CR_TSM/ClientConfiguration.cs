using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPM_CR_TSM
{
    public class ClientConfiguration
    {
        public static ClientConfiguration Default { get { return ClientConfiguration.OneBox; } }

        public static ClientConfiguration OneBox = new ClientConfiguration()
        {
            // You only need to populate this section if you are logging on via a native app. For Service to Service scenarios in which you e.g. use a service principal you don't need that.
            //UriString = "https://mpmr.operations.dynamics.com/",
            UriString = "https://mpmrdevd365it5c26b535f6e2c3e7devaos.axcloud.dynamics.com/",
            UserName = "admin.d365@mpmrentgroup.onmicrosoft.com",
            // Insert the correct password here for the actual test.
            Password = "",

            // You need this only if you logon via service principal using a client secret. See: https://docs.microsoft.com/en-us/dynamics365/unified-operations/dev-itpro/data-entities/services-home-page to get more data on how to populate those fields.
            // You can find that under AAD in the azure portal
            // ActiveDirectoryResource = "https://mpmr.operations.dynamics.com/", // Don't have a trailing "/". Note: Some of the sample code handles that issue.
            ActiveDirectoryResource = "https://mpmrdevd365it5c26b535f6e2c3e7devaos.axcloud.dynamics.com/", // Don't have a trailing "/". Note: Some of the sample code handles that issue.
            ActiveDirectoryTenant = "https://login.windows.net/4ce594ad-0827-4ba4-b156-9841f1555396", // Some samples: https://login.windows.net/yourtenant.onmicrosoft.com, https://login.windows.net/microsoft.com
            ActiveDirectoryClientAppId = "a9867693-16bd-4ba5-9a3e-87a7ffcba18a",
            // Insert here the application secret when authenticate with AAD by the application
            ActiveDirectoryClientAppSecret = "67F8Q~zW5gq8zekfXbdLO5y.4RjOBPxVLKFo2aHf",

            // Change TLS version of HTTP request from the client here
            // Ex: TLSVersion = "1.2"
            // Leave it empty if want to use the default version
            TLSVersion = "",
        };

        public string TLSVersion { get; set; }
        public string UriString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
        public string ActiveDirectoryClientAppSecret { get; set; }
    }
}