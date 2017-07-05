namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Constructors
{
    public class ClassWithNestedStructWithConstructorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public Struct(string text)
            {
            }
        }
    }
}
