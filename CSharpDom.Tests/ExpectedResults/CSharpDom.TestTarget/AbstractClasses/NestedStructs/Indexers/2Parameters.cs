﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithIndexerWith2Parameters
    {
        public struct Struct
        {
            public string this[int x, int y]
            {
                set { }
            }
        }
    }
}
