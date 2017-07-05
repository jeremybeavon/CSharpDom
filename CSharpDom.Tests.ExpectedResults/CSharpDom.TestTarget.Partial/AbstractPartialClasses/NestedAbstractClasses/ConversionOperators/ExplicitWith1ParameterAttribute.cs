namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
