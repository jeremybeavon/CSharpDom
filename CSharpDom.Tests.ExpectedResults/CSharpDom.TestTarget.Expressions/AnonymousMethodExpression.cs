using System;

namespace CSharpDom.TestTarget.Expressions
{
    public sealed class AnonymousMethodExpression
    {
        public Action TestAnomymousMethod()
        {
            return delegate ()
            {
                return;
            };
        }

        public Action<object> TestAnonymousMethodWithParameter()
        {
            return delegate (object obj)
            {
            };
        }

        public Action<object, object> TestAnonymousMethodWithParameters()
        {
            return delegate (object obj1, object obj2)
            {
            };
        }
    }
}
