namespace CSharpDom.TestTarget.Structs.NestedClasses.Constructors
{
    public struct StructWithNestedClassWithConstructorWithParametersWithModifiers
    {
        public class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
