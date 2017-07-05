namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Constructors
{
    public abstract partial class AbstractPartialClassWithConstructorWithParametersWithModifiers
    {
        public AbstractClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
