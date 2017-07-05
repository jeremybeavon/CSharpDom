namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedStructWithConstructorWithParametersWithModifiers
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
