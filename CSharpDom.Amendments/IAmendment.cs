using System;
using System.Linq.Expressions;

namespace CSharpDom.Amendments
{
    public interface IAmendment
    {
        IAmendment Before<TDelegate>(Expression<TDelegate> expression);

        IAmendment Before<TInstance, TDelegate>(Expression<Func<TInstance, TDelegate>> expression);

        IAmendment Before<TInstance>(Expression<Action<TInstance, object[]>> expression);

        IAmendment Before(Expression<Action<object[]>> expression);

        IAmendment After<TDelegate>(Expression<TDelegate> expression);

        IAmendment After<TInstance, TDelegate>(Expression<Func<TInstance, TDelegate>> expression);

        IAmendment After<TInstance>(Expression<Action<TInstance, object[]>> expression);

        IAmendment After<TInstance, TReturnValue>(Expression<Func<TInstance, object[], TReturnValue>> expression);

        IAmendment After(Expression<Action<object[]>> expression);

        
    }
}
