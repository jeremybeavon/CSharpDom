namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedSealedClassWithImplicitConversionOperator
    {
        public sealed class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
