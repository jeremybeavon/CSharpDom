namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public Class()
            {
            }
        }
    }
}
