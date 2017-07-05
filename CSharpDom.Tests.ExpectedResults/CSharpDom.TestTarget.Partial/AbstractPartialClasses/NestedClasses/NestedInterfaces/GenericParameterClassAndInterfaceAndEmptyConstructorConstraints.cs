namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
