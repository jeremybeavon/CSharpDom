﻿namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups : IInterfaceWithIndexer
    {
        [Attribute1]
        [Attribute2]
        string IInterfaceWithIndexer.this[int index]
        {
            get { return default(string); }
            set { }
        }
    }
}
