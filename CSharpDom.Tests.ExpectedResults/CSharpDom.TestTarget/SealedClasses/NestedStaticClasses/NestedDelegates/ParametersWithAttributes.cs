namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
