namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedInterfaces
{
    public struct StructWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
