namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithParametersWithAttributes
    {
        public partial class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
