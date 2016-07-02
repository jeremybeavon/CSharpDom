namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
