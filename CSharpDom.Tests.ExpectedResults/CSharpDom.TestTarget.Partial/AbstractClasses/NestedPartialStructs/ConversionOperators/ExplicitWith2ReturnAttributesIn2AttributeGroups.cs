namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
