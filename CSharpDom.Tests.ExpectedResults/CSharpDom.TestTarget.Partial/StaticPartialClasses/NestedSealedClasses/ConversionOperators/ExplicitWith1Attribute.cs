namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
