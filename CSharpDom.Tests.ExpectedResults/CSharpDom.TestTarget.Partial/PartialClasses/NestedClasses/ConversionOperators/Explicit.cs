namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithExplicitConversionOperator
    {
        public class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
