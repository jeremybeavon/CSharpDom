﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties
{
    public partial struct PartialStructWithNestedSealedClassWithStaticProperty
    {
        public sealed class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
