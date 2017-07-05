namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedSealedPartialClassWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
