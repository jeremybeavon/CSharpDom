namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
