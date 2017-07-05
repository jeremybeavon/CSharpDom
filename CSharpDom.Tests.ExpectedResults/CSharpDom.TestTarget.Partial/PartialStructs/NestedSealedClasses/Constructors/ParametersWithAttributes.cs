namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Constructors
{
    public partial struct PartialStructWithWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
