namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedInterfaceWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public interface Interface
            {
            }
        }
    }
}
