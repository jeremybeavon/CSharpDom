namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
