namespace CSharpDom.TestTarget.Partial.PartialStructs.Constructors
{
    public partial struct PartialStructWithConstructorWithParametersWithModifiers
    {
        public PartialStructWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
