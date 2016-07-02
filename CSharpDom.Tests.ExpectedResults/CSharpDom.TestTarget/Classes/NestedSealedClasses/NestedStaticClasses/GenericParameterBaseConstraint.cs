namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
