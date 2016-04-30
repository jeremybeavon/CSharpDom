namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
