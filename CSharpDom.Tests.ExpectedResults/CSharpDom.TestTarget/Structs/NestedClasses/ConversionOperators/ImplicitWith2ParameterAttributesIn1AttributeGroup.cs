namespace CSharpDom.TestTarget.Structs.NestedClasses.ConversionOperators
{
    public struct StructWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
