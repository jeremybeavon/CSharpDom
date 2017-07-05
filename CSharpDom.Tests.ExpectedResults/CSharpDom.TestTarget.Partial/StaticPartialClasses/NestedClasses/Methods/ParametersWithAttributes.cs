namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedClassWithMethodWithParametersWithAttributes
    {
        public class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
