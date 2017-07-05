namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
