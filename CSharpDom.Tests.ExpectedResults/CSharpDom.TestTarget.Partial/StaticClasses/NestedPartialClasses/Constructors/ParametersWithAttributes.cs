namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Constructors
{
    public static class StaticClassWithNestedPartialClassWithConstructorWithParametersWithAttributes
    {
        public partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
