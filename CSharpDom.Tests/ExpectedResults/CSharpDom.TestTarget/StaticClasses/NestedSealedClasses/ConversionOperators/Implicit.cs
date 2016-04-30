namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedClassWithImplicitConversionOperator
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
