namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWithParametersWithAttributes
    {
        public static partial class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
