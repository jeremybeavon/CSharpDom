namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public class Class
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
