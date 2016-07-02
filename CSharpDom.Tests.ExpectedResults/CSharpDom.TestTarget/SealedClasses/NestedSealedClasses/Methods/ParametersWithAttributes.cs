namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods
{
    public sealed class SealedClassWithNestedSealedClassWithMethodWithParametersWithAttributes
    {
        public sealed class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
