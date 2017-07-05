namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
