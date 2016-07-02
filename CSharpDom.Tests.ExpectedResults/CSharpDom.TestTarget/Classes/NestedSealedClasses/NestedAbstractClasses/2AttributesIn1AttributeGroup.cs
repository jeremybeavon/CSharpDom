namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
