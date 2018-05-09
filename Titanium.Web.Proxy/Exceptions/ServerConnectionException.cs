﻿using System;

namespace Titanium.Web.Proxy.Exceptions
{
    /// <summary>
    /// The server connection was closed. 
    /// </summary>
    public class ServerConnectionException : ProxyException
    {
        internal ServerConnectionException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        internal ServerConnectionException(string message, Exception e) : base(message, e)
        {
        }

    }
}
