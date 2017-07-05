namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods
{
    public partial class PartialClassWithNestedClassWithMethodWithParametersWithModifiers
    {
        public class Class
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
