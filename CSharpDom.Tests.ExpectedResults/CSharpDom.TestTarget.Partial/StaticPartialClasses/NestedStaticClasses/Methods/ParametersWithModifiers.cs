namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Methods
{
    public static partial class StaticPartialClassWithNestedStaticClassWithMethodWithParametersWithModifiers
    {
        public static class Class
        {
            public static void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
