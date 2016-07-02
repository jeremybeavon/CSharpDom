namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Constructors
{
    public sealed class SealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
