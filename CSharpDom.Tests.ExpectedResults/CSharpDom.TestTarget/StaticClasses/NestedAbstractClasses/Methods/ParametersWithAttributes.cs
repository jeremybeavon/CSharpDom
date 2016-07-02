namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithMethodWithParametersWithAttributes
    {
        public abstract class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
