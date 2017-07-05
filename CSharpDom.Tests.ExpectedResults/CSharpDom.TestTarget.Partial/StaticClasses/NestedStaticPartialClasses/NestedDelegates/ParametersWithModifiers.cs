namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public static partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
