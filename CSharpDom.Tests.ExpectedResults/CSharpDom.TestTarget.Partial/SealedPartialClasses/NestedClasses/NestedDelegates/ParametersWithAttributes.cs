namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
