namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
