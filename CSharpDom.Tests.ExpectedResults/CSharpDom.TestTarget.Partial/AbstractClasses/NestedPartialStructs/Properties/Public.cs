﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Properties
{
    public abstract class AbstractClassWithNestedStructWithPublicProperty
    {
        public struct Struct
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
