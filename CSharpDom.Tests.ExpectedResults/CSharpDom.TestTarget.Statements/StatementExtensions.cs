using System;
using System.Collections.Generic;

namespace CSharpDom.TestTarget.Statements
{
    public static class StatementExtensions
    {
        public static bool Condition(this object obj)
        {
            return true;
        }

        public static void MethodCall(this object obj)
        {
        }

        public static void MethodCall(this object obj, object parameter)
        {
        }

        public static void MethodCall(this object obj, out object parameter)
        {
            parameter = null;
        }

        public static IEnumerable<object> Enumerable(this object obj)
        {
            yield break;
        }

        public static int Integer(this object obj)
        {
            return 0;
        }

        public static object LockObject(this object obj)
        {
            return new object();
        }

        public static Exception Exception(this object obj)
        {
            return new Exception();
        }

        public static IDisposable DisposableObject(this object obj)
        {
            return null;
        }
    }
}
