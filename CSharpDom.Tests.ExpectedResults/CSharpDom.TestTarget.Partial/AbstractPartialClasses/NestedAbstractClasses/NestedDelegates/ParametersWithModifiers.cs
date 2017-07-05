namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedDelegateWithParametersWithModifiers
    {
        public abstract class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
