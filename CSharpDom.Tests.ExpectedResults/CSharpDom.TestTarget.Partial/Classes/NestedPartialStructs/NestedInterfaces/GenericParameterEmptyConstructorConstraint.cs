namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
