namespace CSharpDom.TestTarget.Structs.NestedClasses.ConversionOperators
{
    public struct StructWithNestedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public class Class
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
