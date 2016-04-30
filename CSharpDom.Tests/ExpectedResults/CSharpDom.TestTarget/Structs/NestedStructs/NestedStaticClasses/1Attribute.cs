namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedStaticClasses
{
    public struct StructWithNestedStructWithNestedStaticClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static class NestedClass
            {
            }
        }
    }
}
