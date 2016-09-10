using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypedFactory<T> : Dictionary<Type, Func<T>>
    {
        public T Create(Type type)
        {
            Func<T> factory;
            return TryGetValue(type, out factory) ? factory() : default(T);
        }
    }
}
