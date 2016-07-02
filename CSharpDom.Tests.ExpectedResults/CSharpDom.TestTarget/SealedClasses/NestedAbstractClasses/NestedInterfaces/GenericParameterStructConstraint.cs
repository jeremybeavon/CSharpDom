namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
