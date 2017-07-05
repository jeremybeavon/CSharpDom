namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
