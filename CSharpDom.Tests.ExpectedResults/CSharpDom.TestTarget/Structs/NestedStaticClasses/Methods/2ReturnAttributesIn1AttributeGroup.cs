namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods
{
    public struct StructWithNestedStaticClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public static class Class
        {
            [return: Attribute1, Attribute2]
            public static void Method()
            {
            }
        }
    }
}
