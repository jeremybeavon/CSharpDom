﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute
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
