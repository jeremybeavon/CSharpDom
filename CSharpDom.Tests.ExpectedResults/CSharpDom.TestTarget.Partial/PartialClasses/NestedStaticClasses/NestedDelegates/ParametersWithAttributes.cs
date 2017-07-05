namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedDelegates
{
    public partial class PartialClassWithNestedStaticClassWithNestedDelegateWithParametersWithAttributes
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
