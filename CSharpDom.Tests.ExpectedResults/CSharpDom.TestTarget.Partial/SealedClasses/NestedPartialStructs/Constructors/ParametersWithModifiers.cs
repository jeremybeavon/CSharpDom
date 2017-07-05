namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithConstructorWithParametersWithModifiers
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
