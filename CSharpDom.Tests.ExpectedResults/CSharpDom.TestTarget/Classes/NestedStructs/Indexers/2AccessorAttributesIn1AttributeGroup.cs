﻿namespace CSharpDom.TestTarget.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
