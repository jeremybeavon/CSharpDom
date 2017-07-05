namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
