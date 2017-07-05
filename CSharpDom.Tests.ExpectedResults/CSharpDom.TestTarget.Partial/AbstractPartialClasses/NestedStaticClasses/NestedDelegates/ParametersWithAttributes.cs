namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedDelegateWithParametersWithAttributes
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
