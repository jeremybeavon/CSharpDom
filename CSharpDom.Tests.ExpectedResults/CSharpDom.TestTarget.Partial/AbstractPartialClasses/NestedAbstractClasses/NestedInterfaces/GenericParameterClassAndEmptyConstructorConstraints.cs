namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
