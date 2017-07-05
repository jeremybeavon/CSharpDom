namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Constructors
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithConstructorWithParametersWithAttributes
    {
        public abstract partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
