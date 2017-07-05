namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
