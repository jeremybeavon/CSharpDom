using System;

namespace CSharpDom.TestTarget.SealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public sealed class SealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers : IInterfaceWithIndexerWithModifiers
    {
        string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
        {
            set { }
        }
    }
}
