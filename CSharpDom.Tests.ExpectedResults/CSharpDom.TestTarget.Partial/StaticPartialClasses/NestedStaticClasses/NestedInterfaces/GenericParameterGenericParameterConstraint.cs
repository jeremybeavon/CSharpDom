namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
