namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
