namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed partial class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
