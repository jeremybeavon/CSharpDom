namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
    }
}
