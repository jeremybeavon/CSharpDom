namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithConstructorWith1Attribute
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
