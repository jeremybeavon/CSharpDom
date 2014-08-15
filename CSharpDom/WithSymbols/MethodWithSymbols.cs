using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class MethodWithSymbols : AbstractSymbolNode<IMethodWithSymbols>
    {
        private readonly IMethodWithSymbols method;

        public MethodWithSymbols(IMethodWithSymbols method)
            : base(method)
        {
            this.method = method;
        }

        public MethodDeclarationSyntax Declaration
        {
            get { return method.Declaration; }
        }

        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(method.DeclaringType); }
        }

        public int EndLine
        {
            get { return method.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return method.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return method.IsGeneric; }
        }

        public string Name
        {
            get { return method.Name; }
        }

        public int StartLine
        {
            get { return method.StartLine; }
        }

        public IMethodSymbol Symbol
        {
            get { return method.Symbol; }
        }

        public IMethodWithSymbols AsInterface()
        {
            return method;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            method.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
