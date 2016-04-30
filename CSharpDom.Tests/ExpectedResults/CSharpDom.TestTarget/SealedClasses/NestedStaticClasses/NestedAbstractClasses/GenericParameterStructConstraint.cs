namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
