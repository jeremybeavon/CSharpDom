namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
