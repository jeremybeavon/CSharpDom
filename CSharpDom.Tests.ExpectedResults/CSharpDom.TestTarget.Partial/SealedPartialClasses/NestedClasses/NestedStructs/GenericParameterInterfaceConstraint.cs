namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
