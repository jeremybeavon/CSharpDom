namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Constructors
{
    public partial class PartialClassWithNestedStructWithConstructorWithParametersWithAttributes
    {
        public struct Struct
        {
            public Struct([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
