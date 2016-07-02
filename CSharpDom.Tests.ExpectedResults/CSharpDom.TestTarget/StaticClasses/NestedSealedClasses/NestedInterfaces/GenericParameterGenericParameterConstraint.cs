namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
