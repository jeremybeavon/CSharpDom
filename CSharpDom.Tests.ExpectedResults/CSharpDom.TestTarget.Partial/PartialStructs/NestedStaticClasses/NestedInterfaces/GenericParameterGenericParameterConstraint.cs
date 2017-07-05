namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
