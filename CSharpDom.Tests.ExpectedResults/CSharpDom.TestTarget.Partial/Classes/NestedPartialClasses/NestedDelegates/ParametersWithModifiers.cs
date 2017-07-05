namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedDelegates
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
