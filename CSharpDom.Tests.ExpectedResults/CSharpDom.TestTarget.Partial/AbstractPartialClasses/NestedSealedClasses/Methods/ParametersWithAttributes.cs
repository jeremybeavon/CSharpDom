namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithMethodWithParametersWithAttributes
    {
        public sealed class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
