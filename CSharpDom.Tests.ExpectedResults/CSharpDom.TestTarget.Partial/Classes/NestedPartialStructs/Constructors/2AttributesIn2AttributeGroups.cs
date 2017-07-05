namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Constructors
{
    public class ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups
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
