namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWith1Attribute
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
