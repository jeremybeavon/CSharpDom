namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
