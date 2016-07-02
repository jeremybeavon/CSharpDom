namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
