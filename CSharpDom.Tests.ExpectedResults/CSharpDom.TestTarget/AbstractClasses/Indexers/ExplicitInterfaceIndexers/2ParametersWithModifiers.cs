using System;

namespace CSharpDom.TestTarget.AbstractClasses.Indexers.ExplicitInterfaceIndexers
{
    public abstract class AbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers : IInterfaceWithIndexerWithModifiers
    {
        string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
        {
            set { }
        }
    }
}
