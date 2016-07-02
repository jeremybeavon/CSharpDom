namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
