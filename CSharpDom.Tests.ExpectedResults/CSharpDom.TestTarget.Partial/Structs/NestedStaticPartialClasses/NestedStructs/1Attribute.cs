namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStructs
{
    public struct StructWithNestedStaticPartialClassWithNestedStructWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
