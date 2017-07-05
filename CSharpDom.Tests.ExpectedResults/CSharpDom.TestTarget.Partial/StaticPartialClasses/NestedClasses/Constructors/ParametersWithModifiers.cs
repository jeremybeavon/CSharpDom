namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Constructors
{
    public static partial class StaticPartialClassWithNestedClassWithConstructorWithParametersWithModifiers
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
