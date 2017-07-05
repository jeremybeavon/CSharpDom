namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
