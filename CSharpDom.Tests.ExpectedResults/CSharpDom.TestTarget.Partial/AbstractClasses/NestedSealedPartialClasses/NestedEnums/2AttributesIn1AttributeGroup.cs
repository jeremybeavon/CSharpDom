namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedEnums
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
