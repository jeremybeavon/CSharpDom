namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
