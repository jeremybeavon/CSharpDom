namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.ConversionOperators
{
    public partial class PartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract class Class
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
