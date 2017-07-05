namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithConstructorWithParametersWithAttributes
    {
        public struct Struct
        {
            public Struct([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
