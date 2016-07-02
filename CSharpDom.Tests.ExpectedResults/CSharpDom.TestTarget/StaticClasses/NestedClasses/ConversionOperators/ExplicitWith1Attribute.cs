namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators
{
    public static class StaticClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
