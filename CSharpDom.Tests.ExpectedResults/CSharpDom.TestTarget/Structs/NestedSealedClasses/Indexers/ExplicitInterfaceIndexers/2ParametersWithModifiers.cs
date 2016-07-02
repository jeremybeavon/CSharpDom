using System;

namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public sealed class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
