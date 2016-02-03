using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForInitialValueExpression
    {
        IFluentForWhileExpression InitialValues();
        
        IFluentForWhileExpression InitialValues(IFluentExpression expression);

        IFluentForWhileExpression<T> InitialValues<T>(Action<T> action);

        IFluentForWhileExpression<T> InitialValues<T>(T variables, params Action<T>[] actions);
    }
}
