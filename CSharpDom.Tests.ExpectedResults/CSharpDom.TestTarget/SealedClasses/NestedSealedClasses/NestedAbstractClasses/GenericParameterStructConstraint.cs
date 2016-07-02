namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
