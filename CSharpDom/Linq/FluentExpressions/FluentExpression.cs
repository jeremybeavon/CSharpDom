using System;
using System.Collections.Generic;

namespace CSharpDom.Linq.FluentExpressions
{
    public abstract class FluentExpression
    {
        public static IFluentAssignStatement<T> Assign<T>(T value)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Break()
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Continue()
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Declare<T>(Action<T> action)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Declare<T>(Func<T, Block> func)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Declare<T, TReturn>(Func<T, TReturn> func)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Declare<T>(T variables, Action<T> action)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Declare<T>(T variables, Func<T, Block> func)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Declare<T, TReturn>(T variables, Func<T, TReturn> func)
        {
            throw new NotInExpressionException();
        }

        public static IFluentDoStatement Do(Block block)
        {
            throw new NotInExpressionException();
        }

        public static IFluentDoStatement Do(Action statement)
        {
            throw new NotInExpressionException();
        }

        public static IFluentForInitialValueExpression For()
        {
            throw new NotInExpressionException();
        }

        public static IFluentForeachStatement<T> Foreach<T>(IEnumerable<T> enumerable)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Goto(string label)
        {
            throw new NotInExpressionException();
        }

        public static IFluentIfStatement If(bool condition)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Label(string label)
        {
            throw new NotInExpressionException();
        }

        public static IFluentLockStatement Lock<T>(T lockObject)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Return<T>(T returnValue)
        {
            throw new NotInExpressionException();
        }

        public static IFluentExpression Throw<T>(T exception)
            where T : Exception
        {
            throw new NotInExpressionException();
        }

        public static IFluentUsingExpression<T> Using<T>(T disposable)
            where T : IDisposable
        {
            throw new NotInExpressionException();
        }
    }
}
