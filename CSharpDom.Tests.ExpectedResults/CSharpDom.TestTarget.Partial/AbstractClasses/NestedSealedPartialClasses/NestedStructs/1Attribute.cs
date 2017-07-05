namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStructWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
