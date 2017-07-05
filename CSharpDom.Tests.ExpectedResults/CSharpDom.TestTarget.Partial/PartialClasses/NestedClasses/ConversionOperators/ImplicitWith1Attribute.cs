namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithImplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
