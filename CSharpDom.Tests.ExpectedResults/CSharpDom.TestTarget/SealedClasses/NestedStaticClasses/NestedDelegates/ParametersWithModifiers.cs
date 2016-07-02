namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
