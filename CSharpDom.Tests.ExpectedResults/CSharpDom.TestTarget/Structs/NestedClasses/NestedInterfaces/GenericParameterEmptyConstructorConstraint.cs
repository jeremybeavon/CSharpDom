namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedInterfaces
{
    public struct StructWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
