namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
