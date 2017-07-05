namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithImplicitConversionOperator
    {
        public class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
