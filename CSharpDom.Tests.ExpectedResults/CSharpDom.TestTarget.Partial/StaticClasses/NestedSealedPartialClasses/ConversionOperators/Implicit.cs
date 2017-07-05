namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedPartialClassWithImplicitConversionOperator
    {
        public sealed partial class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
