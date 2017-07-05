namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
