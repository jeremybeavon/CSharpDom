using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class StructDeclarationWithSymbols : TypeWithSymbols
    {
        private IStructDeclarationWithSymbols @struct;

        public StructDeclarationWithSymbols(IStructDeclarationWithSymbols @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public StructWithSymbols CompositeType
        {
            get { return new StructWithSymbols(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public DocumentWithSymbols Document
        {
            get { return new DocumentWithSymbols(@struct.Document); }
        }

        public int EndLine
        {
            get { return @struct.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @struct.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @struct.IsGeneric; }
        }

        public string Name
        {
            get { return @struct.Name; }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@struct.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@struct.Solution); }
        }

        public int StartLine
        {
            get { return @struct.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @struct.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
