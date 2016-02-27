using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Constructors<TConstructor>
    {
        public Constructors(
            ITypeWithMonoCecil declaringType,
            Type type,
            Func<ITypeWithMonoCecil, ConstructorInfo, TConstructor> constructorFactory)
        {
            List<TConstructor> constructors = new List<TConstructor>();
            foreach (ConstructorInfo constructor in type.GetAllConstructors())
            {
                if (constructor.IsStatic)
                {
                    StaticConstructorWithMonoCecil = new StaticConstructorWithMonoCecil(declaringType, constructor);
                }
                else
                {
                    constructors.Add(constructorFactory(declaringType, constructor));
                }
            }

            ConstructorsWithMonoCecil = constructors;
        }

        public IReadOnlyCollection<TConstructor> ConstructorsWithMonoCecil { get; private set; }

        public StaticConstructorWithMonoCecil StaticConstructorWithMonoCecil { get; set; }
    }
}
