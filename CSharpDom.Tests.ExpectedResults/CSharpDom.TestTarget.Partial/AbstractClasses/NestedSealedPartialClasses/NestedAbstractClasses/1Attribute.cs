namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public abstract class NestedClass
            {
            }
        }
    }
}
