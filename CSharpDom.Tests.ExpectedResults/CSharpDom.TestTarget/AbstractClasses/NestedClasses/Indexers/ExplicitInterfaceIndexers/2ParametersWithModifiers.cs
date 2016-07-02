using System;

namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
