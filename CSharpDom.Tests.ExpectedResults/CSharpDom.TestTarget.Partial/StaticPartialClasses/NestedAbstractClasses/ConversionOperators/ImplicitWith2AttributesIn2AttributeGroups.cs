namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
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
