namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
