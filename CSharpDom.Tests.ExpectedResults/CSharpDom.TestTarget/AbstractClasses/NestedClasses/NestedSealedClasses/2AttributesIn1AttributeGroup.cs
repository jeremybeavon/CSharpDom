namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
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
