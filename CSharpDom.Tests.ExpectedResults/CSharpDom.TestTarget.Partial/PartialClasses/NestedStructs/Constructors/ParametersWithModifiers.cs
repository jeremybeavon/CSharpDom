namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Constructors
{
    public partial class PartialClassWithNestedStructWithConstructorWithParametersWithModifiers
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
