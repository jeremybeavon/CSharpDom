namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
