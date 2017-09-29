namespace CSharpDom.TestTarget.Partial.PartialClasses.Constructors
{
    public partial class PartialClassWithConstructorWithParametersWithModifiers
    {
        public PartialClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
