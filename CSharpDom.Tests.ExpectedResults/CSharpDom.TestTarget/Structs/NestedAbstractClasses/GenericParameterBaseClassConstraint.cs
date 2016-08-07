namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class<T>
            where T : BaseClass
        {
        }
    }
}
