namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
