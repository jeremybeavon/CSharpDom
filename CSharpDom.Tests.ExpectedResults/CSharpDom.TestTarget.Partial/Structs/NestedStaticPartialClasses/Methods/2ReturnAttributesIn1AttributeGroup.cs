namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [return: Attribute1, Attribute2]
            public static void Method()
            {
            }
        }
    }
}
