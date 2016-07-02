namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Constructors
{
    public static class StaticClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
