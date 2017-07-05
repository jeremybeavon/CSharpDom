namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedStructWithConstructorWithParametersWithAttributes
    {
        public struct Struct
        {
            public Struct([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
