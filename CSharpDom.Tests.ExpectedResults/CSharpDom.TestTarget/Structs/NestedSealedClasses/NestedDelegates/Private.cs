namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates
{
    public struct StructWithNestedSealedClassWithPrivateNestedDelegate
    {
        public sealed class Class
        {
            private delegate void PrivateDelegate();
        }
    }
}
