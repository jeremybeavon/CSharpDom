namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
