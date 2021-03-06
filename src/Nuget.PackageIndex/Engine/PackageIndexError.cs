﻿using System;

namespace Nuget.PackageIndex.Engine
{
    /// <summary>
    /// If an indexing operation over given entry (add/remove) returned error, entry and the actual 
    /// Exception would be wraped by this class and returned to the caller.
    /// </summary>
    public class PackageIndexError
    {
        public object Entry { get; set; }
        public Exception Exception { get; set; }

        public PackageIndexError(object entry, Exception exception)
        {
            Entry = entry;
            Exception = exception;
        }
    }
}
