namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
