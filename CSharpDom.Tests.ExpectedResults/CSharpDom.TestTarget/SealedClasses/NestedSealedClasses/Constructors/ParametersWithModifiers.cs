namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Constructors
{
    public sealed class SealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
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
