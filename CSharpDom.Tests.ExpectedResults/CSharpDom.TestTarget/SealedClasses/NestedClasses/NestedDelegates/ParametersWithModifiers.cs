namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiers
    {
        public class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
