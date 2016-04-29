namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedSealedClasses
{
    public class ClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint
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
