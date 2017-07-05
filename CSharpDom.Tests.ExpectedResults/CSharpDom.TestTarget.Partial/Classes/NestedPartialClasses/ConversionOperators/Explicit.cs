namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.ConversionOperators
{
    public class ClassWithNestedPartialClassWithExplicitConversionOperator
    {
        public partial class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
