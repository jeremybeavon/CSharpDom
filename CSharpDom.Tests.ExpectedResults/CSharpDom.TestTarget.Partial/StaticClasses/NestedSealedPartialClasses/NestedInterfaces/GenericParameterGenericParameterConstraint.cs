namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
