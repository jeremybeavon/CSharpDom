namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors
{
    public static class StaticClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
