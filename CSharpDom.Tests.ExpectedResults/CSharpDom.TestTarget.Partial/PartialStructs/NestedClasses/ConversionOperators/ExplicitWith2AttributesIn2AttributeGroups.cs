namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
