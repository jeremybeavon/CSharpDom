namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.ConversionOperators
{
    public class ClassWithNestedPartialClassWithImplicitConversionOperator
    {
        public partial class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
