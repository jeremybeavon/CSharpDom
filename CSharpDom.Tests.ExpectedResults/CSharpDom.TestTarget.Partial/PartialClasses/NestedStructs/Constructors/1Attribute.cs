namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Constructors
{
    public partial class PartialClassWithNestedStructWithConstructorWith1Attribute
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
