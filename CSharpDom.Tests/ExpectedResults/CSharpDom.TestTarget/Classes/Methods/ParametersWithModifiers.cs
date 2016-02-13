namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithParametersWithModifiers
    {
        public void Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
