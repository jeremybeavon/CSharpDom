namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
