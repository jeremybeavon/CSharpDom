namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Constructors
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
    {
        public abstract class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
