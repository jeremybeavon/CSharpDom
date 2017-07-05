namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups
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
