namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedInterfaces
{
    public struct StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
