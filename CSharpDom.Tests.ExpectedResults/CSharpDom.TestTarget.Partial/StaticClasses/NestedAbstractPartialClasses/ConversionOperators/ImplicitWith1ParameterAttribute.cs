namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract partial class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
