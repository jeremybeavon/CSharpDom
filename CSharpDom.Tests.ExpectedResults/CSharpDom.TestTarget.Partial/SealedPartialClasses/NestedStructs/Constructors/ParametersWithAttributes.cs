namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Constructors
{
    public sealed partial class SealedPartialClassWithNestedStructWithConstructorWithParametersWithAttributes
    {
        public struct Struct
        {
            public Struct([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
