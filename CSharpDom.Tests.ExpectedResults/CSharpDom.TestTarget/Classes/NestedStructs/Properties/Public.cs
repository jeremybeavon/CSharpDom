﻿namespace CSharpDom.TestTarget.Classes.NestedStructs.Properties
{
    public class ClassWithNestedStructWithPublicProperty
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
