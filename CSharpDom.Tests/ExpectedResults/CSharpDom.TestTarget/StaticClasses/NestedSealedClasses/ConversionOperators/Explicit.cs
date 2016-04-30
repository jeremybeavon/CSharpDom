namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedClassWithExplicitConversionOperator
    {
        public sealed class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
