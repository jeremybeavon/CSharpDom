namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedInterfaceWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public interface Interface
            {
            }
        }
    }
}
