namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithParametersWithAttributes
    {
        public partial class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
