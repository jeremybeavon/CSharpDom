namespace CSharpDom.TestTarget.StaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedDelegateWithParametersWithModifiers
    {
        public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
    }
}
