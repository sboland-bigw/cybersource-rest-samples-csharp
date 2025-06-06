using System.Collections.Generic;

namespace SampleCode.data
{
    public class Configuration
    {
        // initialize dictionary object
        private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

        public Dictionary<string, string> GetConfiguration()
        {
            // commented out to confirm this is not being used.
            
          /*  _configurationDictionary.Add("merchantID", "");
            _configurationDictionary.Add("merchantsecretKey", "");
            _configurationDictionary.Add("merchantKeyId", "");
            _configurationDictionary.Add("authenticationType", "JWT");
            _configurationDictionary.Add("keysDirectory", "..\\..\\Resource");
            _configurationDictionary.Add("keyFilename", "");
            _configurationDictionary.Add("keyAlias", "");
            _configurationDictionary.Add("keyPass", "");
            
            //_configurationDictionary.Add("keyFilename", "testrest");
            //_configurationDictionary.Add("runEnvironment", "cybersource.environment.sandbox");
            _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
            //_configurationDictionary.Add("keyAlias", "testrest");
            //_configurationDictionary.Add("keyPass", "testrest");
            _configurationDictionary.Add("enableLog", "TRUE");
            _configurationDictionary.Add("logDirectory", "log");
            _configurationDictionary.Add("logFileName", "cybs");
            _configurationDictionary.Add("logFileMaxSize", "5242880");
            _configurationDictionary.Add("timeout", "1000");
            _configurationDictionary.Add("proxyAddress", string.Empty);
            _configurationDictionary.Add("proxyPort", string.Empty);
*/
            return _configurationDictionary;
        }
    }
}
