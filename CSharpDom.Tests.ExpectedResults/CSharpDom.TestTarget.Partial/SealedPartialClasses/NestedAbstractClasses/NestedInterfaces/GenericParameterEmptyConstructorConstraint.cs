namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
