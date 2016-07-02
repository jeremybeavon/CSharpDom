namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods
{
    public class ClassWithNestedClassWithMethodWithParametersWithModifiers
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
