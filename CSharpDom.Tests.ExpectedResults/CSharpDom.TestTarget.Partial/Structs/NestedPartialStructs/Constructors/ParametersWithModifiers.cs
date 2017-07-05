namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Constructors
{
    public struct StructWithNestedStructWithConstructorWithParametersWithModifiers
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
