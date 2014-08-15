using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class InterfaceDeclarationWithSymbols : BasicTypeWithSymbols
    {
        private readonly IInterfaceDeclarationWithSymbols @interface;

        public InterfaceDeclarationWithSymbols(IInterfaceDeclarationWithSymbols @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public InterfaceWithSymbols CompositeType
        {
            get { return new InterfaceWithSymbols(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public DocumentWithSymbols Document
        {
            get { return new DocumentWithSymbols(@interface.Document); }
        }

        public int EndLine
        {
            get { return @interface.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @interface.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @interface.IsGeneric; }
        }

        public string Name
        {
            get { return @interface.Name; }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@interface.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@interface.Solution); }
        }

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @interface.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
