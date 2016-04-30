namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
