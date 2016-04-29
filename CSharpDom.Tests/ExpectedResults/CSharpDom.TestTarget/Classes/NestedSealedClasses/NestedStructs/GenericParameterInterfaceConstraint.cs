namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
