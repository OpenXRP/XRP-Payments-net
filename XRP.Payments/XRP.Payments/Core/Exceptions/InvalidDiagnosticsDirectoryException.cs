using System;

namespace XRP.Payments.Core.Exceptions
{
    public class InvalidDiagnosticsDirectoryException : Exception
    {
        public InvalidDiagnosticsDirectoryException(string message) : base(message) { }
    }
}
