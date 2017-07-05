namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
