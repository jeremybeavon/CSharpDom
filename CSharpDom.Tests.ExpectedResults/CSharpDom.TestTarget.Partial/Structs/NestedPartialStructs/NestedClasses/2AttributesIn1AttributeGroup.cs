namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
