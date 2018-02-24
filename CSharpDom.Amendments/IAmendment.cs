using System;
using System.Linq.Expressions;

namespace CSharpDom.Amendments
{
    public interface IAmendment
    {
        IAmendment BeforeStaticMethod<TDelegate>(Type type, Expression<TDelegate> expression);

        IAmendment BeforeInstanceMethod<TInstance, TDelegate>(Expression<Func<TInstance, TDelegate>> expression);

        IAmendment BeforeInstanceMethod<TInstance>(Expression<Action<TInstance, object[]>> expression);

        IAmendment BeforeStaticMethod(Type type, Expression<Action<object[]>> expression);

		IAmendment BeforeMethods(Func<ParameterExpression, ParameterExpression[], Expression> callback, params Type[] typeFilter);
		
        IAmendment AfterStaticMethod<TDelegate>(Expression<TDelegate> expression);

        IAmendment AfterInstanceMethod<TInstance, TDelegate>(Expression<Func<TInstance, TDelegate>> expression);

        IAmendment AfterInstanceMethod<TInstance>(Expression<Action<TInstance, object[]>> expression);

        IAmendment AfterInstanceMethod<TInstance, TReturnValue>(Expression<Func<TInstance, object[], TReturnValue>> expression);

        IAmendment AfterStaticMethod(Expression<Action<object[]>> expression);

        
    }
}
