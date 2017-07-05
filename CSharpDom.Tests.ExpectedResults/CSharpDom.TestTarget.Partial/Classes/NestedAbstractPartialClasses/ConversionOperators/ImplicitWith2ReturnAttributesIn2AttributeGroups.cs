namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.ConversionOperators
{
    public class ClassWithNestedAbstractPartialClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract partial class Class
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
