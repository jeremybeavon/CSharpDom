namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Methods
{
    public partial class PartialClassWithNestedStaticClassWithMethodWithParametersWithModifiers
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
