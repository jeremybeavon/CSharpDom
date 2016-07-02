namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
