﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedDelegates
{
    public partial struct PartialStructWithNestedStaticClassWithNestedDelegateWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
