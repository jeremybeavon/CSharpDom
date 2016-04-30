namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Constructors
{
    public static class StaticClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes
    {
        public abstract class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
