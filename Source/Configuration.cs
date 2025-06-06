using System;
using System.Collections.Generic;
using System.IO;

namespace Cybersource_rest_samples_dotnet
{
    public class Configuration
    {
        // initialize dictionary object
        private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

        public Dictionary<string, string> GetConfiguration()
        {
            // We want the JWT authenticationType to use for Certificates 
            _configurationDictionary.Add("authenticationType", "JWT");
            
            // insert your merchantID, merchantsecretKey and merchantKeyId
            _configurationDictionary.Add("merchantID", "<<ENTER YOUR MERCHANT ID HERE>>");
            _configurationDictionary.Add("merchantsecretKey", "<<ENTER YOUR MERCHANT SECRET HERE>>");
            _configurationDictionary.Add("merchantKeyId", "<<ENTER YOUR MERCHANT KEY ID HERE>>");
            
            // Changed the formatting to make it work on a Mac
            _configurationDictionary.Add("keysDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Source//Resource"));
            
            // Change the keyFilename, keyAlias and keyPass to what you downloaded and selected as the keyPass for 
            _configurationDictionary.Add("keyFilename", "<<ENTER YOUR CERTIFICATE FILE NAME HERE WITHOUT THE .p12 suffix>>");
            _configurationDictionary.Add("keyAlias", "<<ENTER YOUR CERTIFICATE FILE NAME HERE WITHOUT THE .p12 suffix>>");
            _configurationDictionary.Add("keyPass", "<<ENTER YOUR CERTIFICATE PASSWORD>>");
            _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
            
            _configurationDictionary.Add("timeout", "300000");

            // Configs related to meta key
            _configurationDictionary.Add("portfolioID", string.Empty);
            _configurationDictionary.Add("useMetaKey", "false");

            // Configs related to OAuth
            _configurationDictionary.Add("enableClientCert", "false");
            _configurationDictionary.Add("clientCertDirectory", "Resource");
            _configurationDictionary.Add("clientCertFile", "");
            _configurationDictionary.Add("clientCertPassword", "");
            _configurationDictionary.Add("clientId", "");
            _configurationDictionary.Add("clientSecret", "");

            /*
             * PEM Key file path for decoding JWE Response Enter the folder path where the .pem file is located.
             * It is optional property, require adding only during JWE decryption.
            */
            _configurationDictionary.Add("pemFileDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Source\\Resource\\NetworkTokenCert.pem"));

            /*
             * Add the property if required to override the cybs default developerId in all request body 
            */
            _configurationDictionary.Add("defaultDeveloperId", "");

            // _configurationDictionary.Add("proxyAddress", string.Empty);
            // _configurationDictionary.Add("proxyPort", string.Empty);
            // _configurationDictionary.Add("proxyUsername", string.Empty);
            // _configurationDictionary.Add("proxyPassword", string.Empty);
            return _configurationDictionary;
        }

        public Dictionary<string, string> GetAlternativeConfiguration()
        {
            _configurationDictionary.Add("authenticationType", "HTTP_SIGNATURE");
            _configurationDictionary.Add("merchantID", "testrest_cpctv");
            _configurationDictionary.Add("merchantsecretKey", "zXKpCqMQPmOR/JRldSlkQUtvvIzOewUVqsUP0sBHpxQ=");
            _configurationDictionary.Add("merchantKeyId", "964f2ecc-96f0-4432-a742-db0b44e6a73a");
            _configurationDictionary.Add("keysDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Source\\Resource"));
            _configurationDictionary.Add("keyFilename", "testrest_cpctv");
            _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
            _configurationDictionary.Add("keyAlias", "testrest_cpctv");
            _configurationDictionary.Add("keyPass", "testrest_cpctv");
            _configurationDictionary.Add("timeout", "300000");
            // _configurationDictionary.Add("proxyAddress", string.Empty);
            // _configurationDictionary.Add("proxyPort", string.Empty);
            // _configurationDictionary.Add("proxyUsername", string.Empty);
            // _configurationDictionary.Add("proxyPassword", string.Empty);

            // Configs related to meta key
            _configurationDictionary.Add("portfolioID", string.Empty);
            _configurationDictionary.Add("useMetaKey", "false");

            // Configs related to OAuth
            _configurationDictionary.Add("enableClientCert", "false");
            _configurationDictionary.Add("clientCertDirectory", "Resource");
            _configurationDictionary.Add("clientCertFile", "");
            _configurationDictionary.Add("clientCertPassword", "");
            _configurationDictionary.Add("clientId", "");
            _configurationDictionary.Add("clientSecret", "");


            return _configurationDictionary;
        }

        public Dictionary<string, string> GetIntermediateConfiguration()
        {
            _configurationDictionary.Add("authenticationType", "HTTP_SIGNATURE");
            _configurationDictionary.Add("merchantID", "testrest");
            _configurationDictionary.Add("merchantsecretKey", "yBJxy6LjM2TmcPGu+GaJrHtkke25fPpUX+UY6/L/1tE=");
            _configurationDictionary.Add("merchantKeyId", "08c94330-f618-42a3-b09d-e1e43be5efda");
            _configurationDictionary.Add("keysDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Source\\Resource"));
            _configurationDictionary.Add("keyFilename", "testrest");
            _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
            //new property has been added for user to configure the base path so that request can route the API calls via Azure Management URL.
            //Example: If intermediate url is https://manage.windowsazure.com then in property input can be same url or manage.windowsazure.com.
            _configurationDictionary.Add("intermediateHost", "https://manage.windowsazure.com");
            _configurationDictionary.Add("keyAlias", "testrest");
            _configurationDictionary.Add("keyPass", "testrest");
            _configurationDictionary.Add("timeout", "300000");

            // Configs related to meta key
            _configurationDictionary.Add("portfolioID", string.Empty);
            _configurationDictionary.Add("useMetaKey", "false");

            // Configs related to OAuth
            _configurationDictionary.Add("enableClientCert", "false");
            _configurationDictionary.Add("clientCertDirectory", "Resource");
            _configurationDictionary.Add("clientCertFile", "");
            _configurationDictionary.Add("clientCertPassword", "");
            _configurationDictionary.Add("clientId", "");
            _configurationDictionary.Add("clientSecret", "");

            // _configurationDictionary.Add("proxyAddress", string.Empty);
            // _configurationDictionary.Add("proxyPort", string.Empty);
            // _configurationDictionary.Add("proxyUsername", string.Empty);
            // _configurationDictionary.Add("proxyPassword", string.Empty);
            
            _configurationDictionary.Add("useMLEGlobally", "true");     //globally MLE will be enabled for all the MLE supported APIs by Cybs in SDK

            return _configurationDictionary;
        }
    }
}
