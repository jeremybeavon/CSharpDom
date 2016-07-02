namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [return: Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
