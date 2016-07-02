namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithNestedDelegateWithParametersWithModifiers
    {
        public abstract class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
