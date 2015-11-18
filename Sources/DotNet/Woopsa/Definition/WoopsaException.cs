﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woopsa
{
	[Serializable]
	public class WoopsaException: Exception
	{
		public WoopsaException()
		{
		}
		public WoopsaException(string message)
			: base(message)
		{
		}
		public WoopsaException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}

	[Serializable]
	public class WoopsaNotFoundException : WoopsaException
    {
		public WoopsaNotFoundException()
		{
		}
		public WoopsaNotFoundException(string message)
			: base(message)
		{
		}
        public WoopsaNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
    }

	[Serializable]
	public class WoopsaInvalidOperationException : WoopsaException
    {
        public WoopsaInvalidOperationException()
        {
        }
        public WoopsaInvalidOperationException(string message)
            : base(message)
        {
        }
        public WoopsaInvalidOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}