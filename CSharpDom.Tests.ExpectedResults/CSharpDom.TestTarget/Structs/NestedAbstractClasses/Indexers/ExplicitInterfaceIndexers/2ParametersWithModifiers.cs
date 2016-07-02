using System;

namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
    {
        public abstract class Class : IInterfaceWithIndexerWithModifiers
        {
            string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
