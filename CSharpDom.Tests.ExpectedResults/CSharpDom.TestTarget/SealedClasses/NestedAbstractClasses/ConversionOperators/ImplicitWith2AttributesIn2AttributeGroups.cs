namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
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
