namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
