namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
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
