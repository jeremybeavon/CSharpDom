namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup
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
