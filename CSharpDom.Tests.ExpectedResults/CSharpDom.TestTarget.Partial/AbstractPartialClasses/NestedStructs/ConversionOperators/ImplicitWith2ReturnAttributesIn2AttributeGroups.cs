namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [return: Attribute1]
            [return: Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
