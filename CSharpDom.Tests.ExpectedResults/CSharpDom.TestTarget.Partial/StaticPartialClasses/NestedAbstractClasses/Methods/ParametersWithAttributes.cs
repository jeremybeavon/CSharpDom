namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithMethodWithParametersWithAttributes
    {
        public abstract class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
