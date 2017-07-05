namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
