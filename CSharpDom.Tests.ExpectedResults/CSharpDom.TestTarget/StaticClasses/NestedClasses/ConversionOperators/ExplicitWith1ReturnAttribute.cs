namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators
{
    public static class StaticClassWithNestedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
