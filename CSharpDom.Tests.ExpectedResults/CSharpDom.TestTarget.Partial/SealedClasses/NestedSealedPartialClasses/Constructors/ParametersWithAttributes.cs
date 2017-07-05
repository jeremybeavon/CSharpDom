namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Constructors
{
    public sealed class SealedClassWithNestedSealedPartialClassWithConstructorWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
