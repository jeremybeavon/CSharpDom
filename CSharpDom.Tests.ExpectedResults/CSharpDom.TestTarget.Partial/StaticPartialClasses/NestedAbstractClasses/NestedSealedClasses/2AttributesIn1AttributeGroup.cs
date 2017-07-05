namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
