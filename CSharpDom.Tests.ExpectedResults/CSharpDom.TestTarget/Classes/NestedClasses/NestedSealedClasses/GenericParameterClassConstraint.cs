namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedSealedClasses
{
    public class ClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
