namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
