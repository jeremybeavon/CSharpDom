namespace CSharpDom.TestTarget.Partial.PartialClasses.Constructors
{
    public partial class PartialClassWithConstructorWithParametersWithModifiers
    {
        public ClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
