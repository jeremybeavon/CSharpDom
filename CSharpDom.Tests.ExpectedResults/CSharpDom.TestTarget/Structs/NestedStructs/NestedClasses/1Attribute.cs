namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
