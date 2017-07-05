namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
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
