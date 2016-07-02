namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
