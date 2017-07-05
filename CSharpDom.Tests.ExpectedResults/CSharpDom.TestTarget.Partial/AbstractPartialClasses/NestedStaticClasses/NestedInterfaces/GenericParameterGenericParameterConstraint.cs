namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
