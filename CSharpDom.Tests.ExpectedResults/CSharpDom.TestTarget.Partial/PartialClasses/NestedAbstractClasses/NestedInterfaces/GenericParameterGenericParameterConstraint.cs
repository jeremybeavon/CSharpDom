namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
