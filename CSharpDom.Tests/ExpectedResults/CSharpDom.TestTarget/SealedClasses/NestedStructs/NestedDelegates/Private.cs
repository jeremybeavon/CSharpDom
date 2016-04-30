namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithPrivateNestedDelegate
    {
        public struct Struct
        {
            private delegate void PrivateDelegate();
        }
    }
}
