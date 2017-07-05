namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public sealed partial class Class
        {
        }
    }
}
