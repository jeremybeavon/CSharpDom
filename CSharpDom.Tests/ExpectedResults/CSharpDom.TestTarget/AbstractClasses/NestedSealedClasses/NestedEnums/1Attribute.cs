namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedEnums
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedEnumWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public enum Enum
            {
            }
        }
    }
}
