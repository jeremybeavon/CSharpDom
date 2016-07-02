namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractClassWithMethodWithParametersWithAttributes
    {
        public abstract class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
