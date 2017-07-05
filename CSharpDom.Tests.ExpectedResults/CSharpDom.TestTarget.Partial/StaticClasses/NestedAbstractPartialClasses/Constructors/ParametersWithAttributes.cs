namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Constructors
{
    public static class StaticClassWithNestedAbstractPartialClassWithConstructorWithParametersWithAttributes
    {
        public abstract partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
