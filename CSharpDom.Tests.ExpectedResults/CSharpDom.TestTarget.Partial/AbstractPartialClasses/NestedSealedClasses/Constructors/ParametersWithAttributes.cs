namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
