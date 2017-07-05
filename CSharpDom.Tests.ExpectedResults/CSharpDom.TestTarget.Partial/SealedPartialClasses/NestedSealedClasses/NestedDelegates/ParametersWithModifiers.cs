namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedDelegateWithParametersWithModifiers
    {
        public sealed class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
