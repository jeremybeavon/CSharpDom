namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedSealedClassWithNestedDelegateWithParametersWithAttributes
    {
        public sealed class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
