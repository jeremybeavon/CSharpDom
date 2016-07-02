namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
