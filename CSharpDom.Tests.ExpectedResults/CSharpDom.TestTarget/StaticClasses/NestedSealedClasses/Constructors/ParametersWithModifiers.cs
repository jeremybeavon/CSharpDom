namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Constructors
{
    public static class StaticClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
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
