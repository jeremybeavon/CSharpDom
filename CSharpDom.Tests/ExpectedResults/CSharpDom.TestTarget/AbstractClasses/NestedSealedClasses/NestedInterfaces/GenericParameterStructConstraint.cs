namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
