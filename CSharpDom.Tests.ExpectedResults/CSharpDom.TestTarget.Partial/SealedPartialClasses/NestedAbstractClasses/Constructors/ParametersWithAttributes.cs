namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Constructors
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes
    {
        public abstract class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
