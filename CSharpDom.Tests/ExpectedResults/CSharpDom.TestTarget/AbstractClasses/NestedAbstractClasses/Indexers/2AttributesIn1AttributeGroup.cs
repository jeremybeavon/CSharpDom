﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
