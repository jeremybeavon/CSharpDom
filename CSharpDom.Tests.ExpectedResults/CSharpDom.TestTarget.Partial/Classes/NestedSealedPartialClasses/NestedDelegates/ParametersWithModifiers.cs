namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedDelegates
{
    public class ClassWithNestedSealedPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
