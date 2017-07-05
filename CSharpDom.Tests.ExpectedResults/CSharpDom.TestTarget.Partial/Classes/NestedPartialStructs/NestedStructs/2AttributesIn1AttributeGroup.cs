namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
