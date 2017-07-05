namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
