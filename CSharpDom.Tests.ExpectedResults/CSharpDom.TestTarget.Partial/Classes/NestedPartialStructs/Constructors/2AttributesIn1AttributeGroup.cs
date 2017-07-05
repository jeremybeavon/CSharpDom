namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Constructors
{
    public class ClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
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
