namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
