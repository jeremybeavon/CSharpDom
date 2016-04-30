namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
