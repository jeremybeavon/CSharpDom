namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
