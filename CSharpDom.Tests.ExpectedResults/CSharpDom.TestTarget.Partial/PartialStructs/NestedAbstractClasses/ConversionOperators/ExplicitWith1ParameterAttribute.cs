namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute
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
