namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Constructors
{
    public struct StructWithNestedSealedPartialClassWithConstructorWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
