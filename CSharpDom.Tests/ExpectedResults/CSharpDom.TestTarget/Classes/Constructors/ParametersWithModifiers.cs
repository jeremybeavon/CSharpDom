namespace CSharpDom.TestTarget.Classes.Constructors
{
    public class ClassWithConstructorWithParametersWithModifiers
    {
        public ClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
