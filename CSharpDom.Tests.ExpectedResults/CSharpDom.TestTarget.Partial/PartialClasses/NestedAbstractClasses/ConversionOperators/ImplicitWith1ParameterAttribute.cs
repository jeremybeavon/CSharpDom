namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.ConversionOperators
{
    public partial class PartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute
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
