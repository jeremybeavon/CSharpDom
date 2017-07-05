namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedSealedPartialClassWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
