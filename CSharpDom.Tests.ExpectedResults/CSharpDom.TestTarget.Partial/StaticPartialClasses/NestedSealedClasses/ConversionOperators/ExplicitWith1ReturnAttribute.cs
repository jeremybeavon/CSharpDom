namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
