namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
