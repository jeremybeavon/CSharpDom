namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
