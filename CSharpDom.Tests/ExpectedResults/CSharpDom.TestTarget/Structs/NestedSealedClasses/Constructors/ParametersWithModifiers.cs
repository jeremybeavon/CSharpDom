namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors
{
    public struct StructWithNestedSealedClassWithConstructorWithParametersWithModifiers
    {
        public sealed class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
