namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithMethodWithParametersWithAttributes
    {
        public abstract partial class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
