namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.ConversionOperators
{
    public struct StructWithNestedAbstractPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
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
