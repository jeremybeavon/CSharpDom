namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators
{
    public static class StaticClassWithNestedClassWithExplicitConversionOperator
    {
        public class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
