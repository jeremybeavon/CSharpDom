namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators
{
    public static class StaticClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public class Class
        {
            [return: Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
