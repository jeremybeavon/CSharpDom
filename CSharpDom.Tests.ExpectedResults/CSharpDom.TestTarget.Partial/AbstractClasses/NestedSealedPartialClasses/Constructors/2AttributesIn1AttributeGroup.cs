namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithConstructorWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public Class()
            {
            }
        }
    }
}
