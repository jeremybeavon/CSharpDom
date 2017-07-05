namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
