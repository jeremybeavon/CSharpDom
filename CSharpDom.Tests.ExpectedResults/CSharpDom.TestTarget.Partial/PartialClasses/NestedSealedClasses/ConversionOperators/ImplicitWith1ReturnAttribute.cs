namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
