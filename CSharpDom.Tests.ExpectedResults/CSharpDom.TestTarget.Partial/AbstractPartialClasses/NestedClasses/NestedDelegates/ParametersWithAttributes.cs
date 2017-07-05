namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
