namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStructs
{
    public struct StructWithNestedStaticClassWithNestedStructWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
