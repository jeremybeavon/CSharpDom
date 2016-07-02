namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedInterfaces
{
    public struct StructWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
