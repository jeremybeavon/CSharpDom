namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
