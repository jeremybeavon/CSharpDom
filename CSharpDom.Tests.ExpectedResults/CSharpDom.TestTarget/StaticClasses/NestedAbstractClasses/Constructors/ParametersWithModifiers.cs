namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Constructors
{
    public static class StaticClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
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
