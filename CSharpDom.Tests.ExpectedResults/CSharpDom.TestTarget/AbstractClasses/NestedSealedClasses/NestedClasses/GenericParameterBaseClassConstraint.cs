namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
