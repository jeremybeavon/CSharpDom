﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Indexers.ExplicitInterfaceIndexers
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceIndexerWith1Attribute
    {
        public struct Struct : IInterfaceWithIndexer
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
