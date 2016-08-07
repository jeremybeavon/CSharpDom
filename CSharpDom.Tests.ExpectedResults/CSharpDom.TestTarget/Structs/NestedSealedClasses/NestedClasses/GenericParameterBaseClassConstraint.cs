namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedClasses
{
    public struct StructWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint
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
