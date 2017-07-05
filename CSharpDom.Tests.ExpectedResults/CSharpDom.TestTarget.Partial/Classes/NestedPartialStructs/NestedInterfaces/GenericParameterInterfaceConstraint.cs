namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
