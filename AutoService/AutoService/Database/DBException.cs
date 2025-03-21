﻿namespace AutoService.Database
{
    [Serializable]
    internal class DBException : Exception
    {
        public DBException() { }

        public DBException(string message) : base(message) { }

        public DBException(string message, Exception innerException) : base(message, innerException) { }
    }
}
