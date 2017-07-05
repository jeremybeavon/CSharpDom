namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithParametersWithModifiers
    {
        public void Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
