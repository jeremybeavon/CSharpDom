using System;

namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
