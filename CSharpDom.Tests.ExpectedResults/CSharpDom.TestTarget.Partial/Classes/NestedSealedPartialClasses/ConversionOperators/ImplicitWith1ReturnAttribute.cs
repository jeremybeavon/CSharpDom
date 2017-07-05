namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.ConversionOperators
{
    public class ClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
