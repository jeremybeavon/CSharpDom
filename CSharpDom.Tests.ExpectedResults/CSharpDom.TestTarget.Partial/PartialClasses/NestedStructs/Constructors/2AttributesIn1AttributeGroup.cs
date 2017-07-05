namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Constructors
{
    public partial class PartialClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
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
