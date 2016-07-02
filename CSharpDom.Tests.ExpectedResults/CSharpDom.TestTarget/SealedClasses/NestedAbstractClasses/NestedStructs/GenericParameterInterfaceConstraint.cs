namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
