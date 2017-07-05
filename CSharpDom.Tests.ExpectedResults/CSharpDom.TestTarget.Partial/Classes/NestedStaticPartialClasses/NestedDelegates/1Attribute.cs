namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedDelegates
{
    public class ClassWithNestedStaticPartialClassWithNestedDelegateWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
