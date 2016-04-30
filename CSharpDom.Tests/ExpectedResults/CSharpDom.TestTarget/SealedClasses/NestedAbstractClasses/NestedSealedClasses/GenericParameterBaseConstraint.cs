namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
