namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Methods
{
    public static class StaticClassWithNestedStaticClassWithMethodWithParametersWithModifiers
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
