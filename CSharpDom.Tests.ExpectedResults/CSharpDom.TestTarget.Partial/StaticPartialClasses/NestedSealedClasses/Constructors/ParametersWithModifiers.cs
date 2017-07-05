namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Constructors
{
    public static partial class StaticPartialClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
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
