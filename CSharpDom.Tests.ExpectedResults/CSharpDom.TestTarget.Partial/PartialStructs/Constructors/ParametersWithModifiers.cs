namespace CSharpDom.TestTarget.Partial.PartialStructs.Constructors
{
    public partial struct PartialStructWithWithConstructorWithParametersWithModifiers
    {
        public StructWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
