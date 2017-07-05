namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
