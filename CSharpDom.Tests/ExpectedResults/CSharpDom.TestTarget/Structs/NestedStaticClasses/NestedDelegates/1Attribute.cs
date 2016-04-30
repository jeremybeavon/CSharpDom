namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedDelegates
{
    public struct StructWithNestedStaticClassWithNestedDelegateWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
