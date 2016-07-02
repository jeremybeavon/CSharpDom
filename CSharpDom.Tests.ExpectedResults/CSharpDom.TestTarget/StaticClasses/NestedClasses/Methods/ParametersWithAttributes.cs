namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods
{
    public static class StaticClassWithNestedClassWithMethodWithParametersWithAttributes
    {
        public class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
