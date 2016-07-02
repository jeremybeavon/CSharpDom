namespace CSharpDom.TestTarget.SealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedDelegateWithParametersWithModifiers
    {
        public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
    }
}
