namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedDelegateWithParametersWithAttributes
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
