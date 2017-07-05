namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithParametersWithModifiers
    {
        public void Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
