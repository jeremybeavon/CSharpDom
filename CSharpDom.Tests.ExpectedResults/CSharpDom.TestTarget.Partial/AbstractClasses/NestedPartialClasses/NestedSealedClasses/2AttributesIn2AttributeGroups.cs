namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedSealedPartialClassWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
