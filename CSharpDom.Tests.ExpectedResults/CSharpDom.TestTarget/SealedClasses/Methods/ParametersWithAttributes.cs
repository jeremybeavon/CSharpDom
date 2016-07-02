namespace CSharpDom.TestTarget.SealedClasses.Methods
{
    public sealed class SealedClassWithMethodWithParametersWithAttributes
    {
        public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
