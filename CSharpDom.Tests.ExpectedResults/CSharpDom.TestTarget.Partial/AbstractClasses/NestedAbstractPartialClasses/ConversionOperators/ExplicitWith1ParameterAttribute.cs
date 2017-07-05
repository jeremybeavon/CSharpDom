namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract partial class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
