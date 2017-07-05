namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithParametersWithModifiers
    {
        public static partial class Class
        {
            public static void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
