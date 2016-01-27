using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Constructors
    {
        public Constructors(ITypeWithReflection declaringType, Type type)
        {
            ConstructorsWithReflection = type.GetAllConstructors()
                .Select(constructor => new ConstructorWithReflection(declaringType, constructor))
                .ToList();
        }

        public IReadOnlyCollection<ConstructorWithReflection> ConstructorsWithReflection { get; private set; }
    }
}
