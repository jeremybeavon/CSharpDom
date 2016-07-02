namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
