using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuelSDK;
using System.Configuration;
using System.Collections.Specialized;

namespace FuelSDK.Tests
{
    [TestClass]
    public class ETClientTest
    {
        private NameValueCollection _parameters;

        [TestInitialize]
        public void Init()
        {
            _parameters = new NameValueCollection();
            _parameters.Add("clientId","Dummy Id");
            _parameters.Add("clientSecret", "Its a secret, dont tell anybody");
            _parameters.Add("appSignature", "Autograph");
            
        }

        [TestMethod]
        [ExpectedException(typeof(ClientCredentialMissingException))]
        public void ETClientNoClientId()
        {
            //set empty to client id and save the configuration to simulate emtpy client id  in config file
            _parameters["clientId"] = "test";

            //now construct a ET_Client object
            var etClient = new ET_Client(_parameters);
        }

        [TestMethod]
        [ExpectedException(typeof(ClientCredentialMissingException))]
        public void ETClientNoClientSecret()
        {
            //set empty to client id and save the configuration to simulate emtpy client id  in config file
            _parameters["clientSecret"] = string.Empty;

            //now construct a ET_Client object
            var etClient = new ET_Client(_parameters);
        }

        [TestMethod]
        [ExpectedException(typeof(AppSignatureMissingException))]
        public void ETClientNoAppSignature()
        {
            //set empty to client id and save the configuration to simulate emtpy client id  in config file
            _parameters["appSignature"] = string.Empty;
            _parameters.Add("jwt", "{'item1','value1'}");

            //now construct a ET_Client object
            var etClient = new ET_Client(_parameters);
        }
    }
}
