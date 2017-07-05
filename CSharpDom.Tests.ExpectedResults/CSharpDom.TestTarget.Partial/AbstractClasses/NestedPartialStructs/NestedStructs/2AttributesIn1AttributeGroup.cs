namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup
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
