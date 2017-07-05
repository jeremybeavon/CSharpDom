namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithParametersWithModifiers
    {
        public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
    }
}
