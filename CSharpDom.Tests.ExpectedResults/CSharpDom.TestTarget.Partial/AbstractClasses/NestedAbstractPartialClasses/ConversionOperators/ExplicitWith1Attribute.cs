namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
