namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
