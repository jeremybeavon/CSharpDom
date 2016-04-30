namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStructs
{
    public static class StaticClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint
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
