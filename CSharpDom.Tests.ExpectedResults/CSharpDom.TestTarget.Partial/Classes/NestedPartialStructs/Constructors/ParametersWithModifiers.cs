namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Constructors
{
    public class ClassWithNestedStructWithConstructorWithParametersWithModifiers
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
