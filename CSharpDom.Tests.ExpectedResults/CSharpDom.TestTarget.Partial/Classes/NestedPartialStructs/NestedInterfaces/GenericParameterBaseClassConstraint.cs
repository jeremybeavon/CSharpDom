namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
