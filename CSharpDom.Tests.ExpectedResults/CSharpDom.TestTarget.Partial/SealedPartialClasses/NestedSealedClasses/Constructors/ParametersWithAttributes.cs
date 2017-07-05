namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Constructors
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
