namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute
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
