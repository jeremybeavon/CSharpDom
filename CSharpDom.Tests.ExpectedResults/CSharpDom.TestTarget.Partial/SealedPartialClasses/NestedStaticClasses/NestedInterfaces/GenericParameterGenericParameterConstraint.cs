namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
