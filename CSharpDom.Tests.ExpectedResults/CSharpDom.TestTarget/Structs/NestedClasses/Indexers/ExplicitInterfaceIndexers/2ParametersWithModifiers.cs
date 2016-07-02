using System;

namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers.ExplicitInterfaceIndexers
{
    public struct StructWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers
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
