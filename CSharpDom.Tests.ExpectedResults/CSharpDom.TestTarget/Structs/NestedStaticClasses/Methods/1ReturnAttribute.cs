namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods
{
    public struct StructWithNestedStaticClassWithMethodWith1ReturnAttribute
    {
        public static class Class
        {
            [return: Attribute1]
            public static void Method()
            {
            }
        }
    }
}
