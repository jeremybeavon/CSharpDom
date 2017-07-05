namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
