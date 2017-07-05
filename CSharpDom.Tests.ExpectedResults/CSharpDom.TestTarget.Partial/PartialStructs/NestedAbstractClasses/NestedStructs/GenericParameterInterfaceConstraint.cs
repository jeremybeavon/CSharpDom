namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint
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
