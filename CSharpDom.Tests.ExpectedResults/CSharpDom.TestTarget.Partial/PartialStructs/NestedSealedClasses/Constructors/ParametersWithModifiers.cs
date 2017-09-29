namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Constructors
{
    public partial struct PartialStructWithNestedSealedClassWithConstructorWithParametersWithModifiers
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
