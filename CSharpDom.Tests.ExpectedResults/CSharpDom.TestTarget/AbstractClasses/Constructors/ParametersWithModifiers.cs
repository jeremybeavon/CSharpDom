namespace CSharpDom.TestTarget.AbstractClasses.Constructors
{
    public abstract class AbstractClassWithConstructorWithParametersWithModifiers
    {
        public AbstractClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
