namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups
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
