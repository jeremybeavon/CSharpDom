namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
