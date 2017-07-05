namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
