namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
