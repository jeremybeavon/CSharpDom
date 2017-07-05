namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public class Class
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
