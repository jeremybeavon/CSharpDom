namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
