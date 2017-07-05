namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStructs
{
    public struct StructWithNestedAbstractPartialClassWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
