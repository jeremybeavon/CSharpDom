namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
