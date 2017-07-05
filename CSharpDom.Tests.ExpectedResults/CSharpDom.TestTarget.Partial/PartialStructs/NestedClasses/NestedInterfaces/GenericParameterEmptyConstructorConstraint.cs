namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
