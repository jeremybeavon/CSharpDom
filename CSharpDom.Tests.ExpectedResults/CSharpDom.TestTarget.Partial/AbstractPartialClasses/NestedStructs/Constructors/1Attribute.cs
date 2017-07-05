namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedStructWithConstructorWith1Attribute
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
