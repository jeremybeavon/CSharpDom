namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public static implicit operator Struct([Attribute1][Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
