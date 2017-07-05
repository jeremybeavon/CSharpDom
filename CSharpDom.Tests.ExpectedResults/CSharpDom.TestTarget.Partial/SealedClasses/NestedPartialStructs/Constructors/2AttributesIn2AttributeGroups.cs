namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups
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
