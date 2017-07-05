namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStructs
{
    public struct StructWithNestedStaticPartialClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
