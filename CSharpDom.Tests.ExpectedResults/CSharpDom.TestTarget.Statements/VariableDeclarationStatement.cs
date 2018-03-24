namespace CSharpDom.TestTarget.Statements
{
    public sealed class VariableDeclarationStatement
    {
        public void TestVariableDeclaration()
        {
            object obj;
            this.MethodCall(out obj);
        }

        public void TestMultipleVariableDeclarations()
        {
            object obj1, obj2;
            this.MethodCall(out obj1);
            this.MethodCall(out obj2);
        }

        public void TestVariableDeclarationWithInitializer()
        {
            object obj1 = new object();
            this.MethodCall(obj1);
        }

        public void TestMultipleVariableDeclarationsWithInitializer()
        {
            object obj1, obj2 = new object();
            object obj3 = new object(), obj4;
            object obj5 = new object(), obj6 = new object();
            this.MethodCall(out obj1);
            this.MethodCall(obj2);
            this.MethodCall(obj3);
            this.MethodCall(out obj4);
            this.MethodCall(obj5);
            this.MethodCall(obj6);
        }

        public void TestConstVariableDeclaration()
        {
            const int index = 0;
            this.MethodCall(index);
        }

        public void TestMultipleConstVariableDeclarations()
        {
            const int index = 0, index2 = 0;
            this.MethodCall(index);
            this.MethodCall(index2);
        }
    }
}
