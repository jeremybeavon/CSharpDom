namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
