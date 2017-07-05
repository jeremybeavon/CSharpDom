namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Constructors
{
    public static class StaticClassWithNestedAbstractPartialClassWithConstructorWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
