namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedDelegateWithParametersWithModifiers
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
