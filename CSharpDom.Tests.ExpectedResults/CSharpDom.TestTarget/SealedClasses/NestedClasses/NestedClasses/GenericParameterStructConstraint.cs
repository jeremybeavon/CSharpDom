namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
