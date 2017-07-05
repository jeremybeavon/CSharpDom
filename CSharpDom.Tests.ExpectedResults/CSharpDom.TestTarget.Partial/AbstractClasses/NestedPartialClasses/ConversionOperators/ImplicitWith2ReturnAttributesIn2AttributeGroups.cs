namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedPartialClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
