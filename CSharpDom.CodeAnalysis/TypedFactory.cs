using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypedFactory<T> : Dictionary<Type, Func<T>>
    {
        public T Create(Type type)
        {
            if (TryGetValue(type, out Func<T> factory))
            {
                return factory();
            }

            throw new InvalidOperationException("Factory not found: " + type.Name);
        }
    }
}
