namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedEnums
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public enum Enum
            {
            }
        }
    }
}
