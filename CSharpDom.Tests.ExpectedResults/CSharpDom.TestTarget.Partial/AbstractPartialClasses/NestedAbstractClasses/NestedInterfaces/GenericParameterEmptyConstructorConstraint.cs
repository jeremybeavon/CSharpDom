namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
