namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
