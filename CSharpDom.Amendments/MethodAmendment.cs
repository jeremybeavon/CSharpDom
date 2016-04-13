using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Amendments
{
    internal sealed class MethodAmendment : IAmendment
    {
        public IAmendment After(Expression<Action<object[]>> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment After<TInstance>(Expression<Action<TInstance, object[]>> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment After<TDelegate>(Expression<TDelegate> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment After<TInstance, TReturnValue>(Expression<Func<TInstance, object[], TReturnValue>> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment After<TInstance, TDelegate>(Expression<Func<TInstance, TDelegate>> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment Before(Expression<Action<object[]>> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment Before<TInstance>(Expression<Action<TInstance, object[]>> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment Before<TDelegate>(Expression<TDelegate> expression)
        {
            throw new NotImplementedException();
        }

        public IAmendment Before<TInstance, TDelegate>(Expression<Func<TInstance, TDelegate>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
