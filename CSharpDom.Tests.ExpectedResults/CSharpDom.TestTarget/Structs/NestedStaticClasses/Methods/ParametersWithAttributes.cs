namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods
{
    public struct StructWithNestedStaticClassWithMethodWithParametersWithAttributes
    {
        public static class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
