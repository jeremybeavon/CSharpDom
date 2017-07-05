namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedDelegateWithParametersWithModifiers
    {
        public abstract class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
