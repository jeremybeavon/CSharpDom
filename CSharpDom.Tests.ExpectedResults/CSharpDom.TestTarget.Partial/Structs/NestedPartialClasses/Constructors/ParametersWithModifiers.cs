namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Constructors
{
    public struct StructWithNestedPartialClassWithConstructorWithParametersWithModifiers
    {
        public partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
