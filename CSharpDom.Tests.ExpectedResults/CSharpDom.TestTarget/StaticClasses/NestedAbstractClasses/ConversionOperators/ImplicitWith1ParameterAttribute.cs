namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
