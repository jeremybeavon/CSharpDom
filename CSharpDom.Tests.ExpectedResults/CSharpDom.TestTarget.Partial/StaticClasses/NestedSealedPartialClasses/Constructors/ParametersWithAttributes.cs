namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Constructors
{
    public static class StaticClassWithNestedSealedPartialClassWithConstructorWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
