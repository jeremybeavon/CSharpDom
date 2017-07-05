namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Constructors
{
    public abstract class AbstractClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
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
