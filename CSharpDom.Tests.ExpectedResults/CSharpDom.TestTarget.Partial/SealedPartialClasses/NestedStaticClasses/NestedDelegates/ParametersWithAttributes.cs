namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedDelegateWithParametersWithAttributes
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
