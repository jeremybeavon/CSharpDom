namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
