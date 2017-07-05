namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitConversionOperator
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
