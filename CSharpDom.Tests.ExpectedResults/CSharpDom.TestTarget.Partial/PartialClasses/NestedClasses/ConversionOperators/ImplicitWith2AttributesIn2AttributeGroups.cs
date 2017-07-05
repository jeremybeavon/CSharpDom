namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
