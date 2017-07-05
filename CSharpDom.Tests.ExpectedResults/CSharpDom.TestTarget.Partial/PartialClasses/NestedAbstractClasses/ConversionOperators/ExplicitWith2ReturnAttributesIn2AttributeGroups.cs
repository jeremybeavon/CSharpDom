namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.ConversionOperators
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
