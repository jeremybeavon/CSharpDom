namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Constructors
{
    public abstract class AbstractClassWithNestedStructWithConstructorWith1Attribute
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
