namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
