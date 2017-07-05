namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class<T>
            where T : BaseClass
        {
        }
    }
}
