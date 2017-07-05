namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
