namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
