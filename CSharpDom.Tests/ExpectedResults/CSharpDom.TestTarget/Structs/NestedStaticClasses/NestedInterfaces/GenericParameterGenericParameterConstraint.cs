namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces
{
    public struct StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
