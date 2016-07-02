namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedDelegates
{
    public class ClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers
    {
        public static class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
