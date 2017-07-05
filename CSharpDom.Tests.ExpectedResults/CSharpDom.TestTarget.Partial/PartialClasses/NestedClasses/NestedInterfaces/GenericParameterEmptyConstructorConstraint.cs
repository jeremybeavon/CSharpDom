namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
