namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
