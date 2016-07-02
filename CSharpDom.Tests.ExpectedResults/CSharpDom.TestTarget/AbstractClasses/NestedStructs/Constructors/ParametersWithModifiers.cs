namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Constructors
{
    public abstract class AbstractClassWithNestedStructWithConstructorWithParametersWithModifiers
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
