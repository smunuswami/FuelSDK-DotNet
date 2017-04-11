using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuelSDK
{
    /// <summary>
    /// AppSignatureMissingException : 
    /// Use it throw exception when App Signature is missing or empty in the configuration.
    /// </summary>
    public class AppSignatureMissingException : ApplicationException
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AppSignatureMissingException() { }

        /// <summary>
        /// Constructor with exception message as parameter.
        /// </summary>
        /// <param name="message">Exception message</param>
        public AppSignatureMissingException(string message)
        : base(message)
        {
        }
    }

    /// <summary>
    /// ClientCredentialMissingException : 
    /// Use it throw exception when Client Id or Client secret is missing or empty.
    /// </summary>
    public class ClientCredentialMissingException : ApplicationException
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ClientCredentialMissingException() { }

        /// <summary>
        /// Constructor with exception message as parameter.
        /// </summary>
        /// <param name="message">Exception message</param>
        public ClientCredentialMissingException(string message)
        : base(message)
        {
        }
    }
}
