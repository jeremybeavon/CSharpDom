namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Constructors
{
    public sealed partial class SealedPartialClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public Struct(string text)
            {
            }
        }
    }
}
