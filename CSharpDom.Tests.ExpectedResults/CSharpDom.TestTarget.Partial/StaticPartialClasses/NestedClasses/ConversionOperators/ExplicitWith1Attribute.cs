namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
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
