namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Constructors
{
    public abstract class AbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups
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
