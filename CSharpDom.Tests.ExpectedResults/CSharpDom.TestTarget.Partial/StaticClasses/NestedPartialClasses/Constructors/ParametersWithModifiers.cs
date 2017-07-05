namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Constructors
{
    public static class StaticClassWithNestedPartialClassWithConstructorWithParametersWithModifiers
    {
        public partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
