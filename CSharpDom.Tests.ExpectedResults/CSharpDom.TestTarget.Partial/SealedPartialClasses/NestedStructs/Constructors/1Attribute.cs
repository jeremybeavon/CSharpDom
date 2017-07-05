namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Constructors
{
    public sealed partial class SealedPartialClassWithNestedStructWithConstructorWith1Attribute
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
