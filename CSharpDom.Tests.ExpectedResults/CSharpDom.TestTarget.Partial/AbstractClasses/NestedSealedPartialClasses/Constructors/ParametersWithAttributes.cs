namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithConstructorWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
