using System;
using System.Runtime.Serialization;

namespace CSharpDom.Linq.FluentExpressions
{
    [Serializable]
    public class NotInExpressionException : Exception
    {
        public NotInExpressionException()
        {
        }

        public NotInExpressionException(string message)
            : base(message)
        {
        }

        public NotInExpressionException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected NotInExpressionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
