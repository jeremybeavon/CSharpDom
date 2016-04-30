namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
