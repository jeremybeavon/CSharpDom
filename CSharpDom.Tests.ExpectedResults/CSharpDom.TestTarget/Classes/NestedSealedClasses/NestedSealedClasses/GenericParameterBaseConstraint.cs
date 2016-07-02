namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
