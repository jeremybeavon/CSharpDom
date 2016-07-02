namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
