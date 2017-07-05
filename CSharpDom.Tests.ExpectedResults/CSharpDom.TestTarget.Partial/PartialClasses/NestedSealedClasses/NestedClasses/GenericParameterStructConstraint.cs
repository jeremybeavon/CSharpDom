namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
