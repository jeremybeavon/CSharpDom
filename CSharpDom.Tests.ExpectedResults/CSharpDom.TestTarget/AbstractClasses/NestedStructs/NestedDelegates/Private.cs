namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithPrivateNestedDelegate
    {
        public struct Struct
        {
            private delegate void PrivateDelegate();
        }
    }
}
