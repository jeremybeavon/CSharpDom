namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
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
