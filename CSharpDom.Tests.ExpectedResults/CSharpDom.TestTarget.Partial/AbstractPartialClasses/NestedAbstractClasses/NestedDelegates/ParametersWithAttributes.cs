namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedDelegateWithParametersWithAttributes
    {
        public abstract class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
