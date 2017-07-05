namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithParametersWithAttributes
    {
        public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
    }
}
