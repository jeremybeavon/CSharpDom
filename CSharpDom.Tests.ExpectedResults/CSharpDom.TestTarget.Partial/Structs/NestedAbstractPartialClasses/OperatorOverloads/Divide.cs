namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractPartialClassWithDivideOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator /(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
