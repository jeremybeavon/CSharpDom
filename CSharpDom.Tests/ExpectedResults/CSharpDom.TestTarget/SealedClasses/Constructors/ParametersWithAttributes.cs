namespace CSharpDom.TestTarget.SealedClasses.Constructors
{
    public sealed class SealedClassWithConstructorWithParametersWithAttributes
    {
        public SealedClassWithConstructorWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
