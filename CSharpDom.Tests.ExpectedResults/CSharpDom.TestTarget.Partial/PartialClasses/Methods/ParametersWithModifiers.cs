namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithParametersWithModifiers
    {
        public void Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
