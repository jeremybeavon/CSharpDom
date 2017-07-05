namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
