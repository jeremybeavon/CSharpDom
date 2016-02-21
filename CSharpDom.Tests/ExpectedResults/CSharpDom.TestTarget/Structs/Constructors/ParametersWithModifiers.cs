namespace CSharpDom.TestTarget.Structs.Constructors
{
    public struct StructWithConstructorWithParametersWithModifiers
    {
        public StructWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
