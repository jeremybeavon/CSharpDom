namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Constructors
{
    public static class StaticClassWithNestedSealedPartialClassWithConstructorWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
