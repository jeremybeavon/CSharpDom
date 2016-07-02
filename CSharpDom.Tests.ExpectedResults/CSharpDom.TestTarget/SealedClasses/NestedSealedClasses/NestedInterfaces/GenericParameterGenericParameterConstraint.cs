namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
