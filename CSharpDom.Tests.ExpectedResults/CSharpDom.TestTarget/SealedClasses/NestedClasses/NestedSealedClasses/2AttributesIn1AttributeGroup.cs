namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
