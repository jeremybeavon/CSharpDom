namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Constructors
{
    public partial struct PartialStructWithWithNestedStructWithConstructorWithParametersWithModifiers
    {
        public struct Struct
        {
            public Struct(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
