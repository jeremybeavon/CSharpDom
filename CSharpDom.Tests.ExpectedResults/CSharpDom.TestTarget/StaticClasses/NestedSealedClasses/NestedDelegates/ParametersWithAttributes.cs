namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public sealed class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
