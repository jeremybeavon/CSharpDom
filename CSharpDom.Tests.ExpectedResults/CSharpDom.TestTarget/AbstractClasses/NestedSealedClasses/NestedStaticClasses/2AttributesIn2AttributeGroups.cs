namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
