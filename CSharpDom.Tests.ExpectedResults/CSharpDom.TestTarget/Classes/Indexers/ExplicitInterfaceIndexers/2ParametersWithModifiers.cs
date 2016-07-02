using System;

namespace CSharpDom.TestTarget.Classes.Indexers.ExplicitInterfaceIndexers
{
    public class ClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers : IInterfaceWithIndexerWithModifiers
    {
        string IInterfaceWithIndexerWithModifiers.this[params string[] descriptions]
        {
            set { }
        }
    }
}
