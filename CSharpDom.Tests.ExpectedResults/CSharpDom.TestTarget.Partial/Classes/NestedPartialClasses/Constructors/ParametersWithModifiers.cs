namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Constructors
{
    public class ClassWithNestedPartialClassWithConstructorWithParametersWithModifiers
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
