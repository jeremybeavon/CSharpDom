namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
