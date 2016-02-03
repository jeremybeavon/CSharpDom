using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Constructors<TConstructor>
    {
        public Constructors(
            ITypeWithReflection declaringType,
            Type type,
            Func<ITypeWithReflection, ConstructorInfo, TConstructor> constructorFactory)
        {
            List<TConstructor> constructors = new List<TConstructor>();
            foreach (ConstructorInfo constructor in type.GetAllConstructors())
            {
                if (constructor.IsStatic)
                {
                    StaticConstructorWithReflection = new StaticConstructorWithReflection(declaringType, constructor);
                }
                else
                {
                    constructors.Add(constructorFactory(declaringType, constructor));
                }
            }

            ConstructorsWithReflection = constructors;
        }

        public IReadOnlyCollection<TConstructor> ConstructorsWithReflection { get; private set; }

        public StaticConstructorWithReflection StaticConstructorWithReflection { get; set; }
    }
}
