namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.ConversionOperators
{
    public class ClassWithNestedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public partial class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
