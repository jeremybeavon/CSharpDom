﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute
    {
        public sealed class Class : IInterfaceWithIndexer
        {
            [Attribute1]
            string IInterfaceWithIndexer.this[int index]
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
