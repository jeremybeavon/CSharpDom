namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
