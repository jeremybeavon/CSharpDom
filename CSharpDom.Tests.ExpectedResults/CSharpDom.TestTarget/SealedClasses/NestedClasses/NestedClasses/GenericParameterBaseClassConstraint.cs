namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
