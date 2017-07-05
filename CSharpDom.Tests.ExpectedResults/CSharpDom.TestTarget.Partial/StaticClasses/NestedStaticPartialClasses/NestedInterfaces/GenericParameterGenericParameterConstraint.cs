namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
