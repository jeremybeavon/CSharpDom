namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWith1ReturnAttribute
    {
        public static partial class Class
        {
            [return: Attribute1]
            public static void Method()
            {
            }
        }
    }
}
