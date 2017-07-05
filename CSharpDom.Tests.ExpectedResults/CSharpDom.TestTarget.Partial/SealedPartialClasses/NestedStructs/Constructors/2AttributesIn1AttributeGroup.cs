namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Constructors
{
    public sealed partial class SealedPartialClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public Struct(string text)
            {
            }
        }
    }
}
