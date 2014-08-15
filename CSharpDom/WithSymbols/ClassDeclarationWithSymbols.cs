using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class ClassDeclarationWithSymbols : TypeWithSymbols
    {
        private readonly IClassDeclarationWithSymbols @class;

        public ClassDeclarationWithSymbols(IClassDeclarationWithSymbols @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public ClassWithSymbols CompositeType
        {
            get { return new ClassWithSymbols(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public DestructorWithSymbols Destructor
        {
            get { return new DestructorWithSymbols(@class.Destructor); }
        }

        public DocumentWithSymbols Document
        {
            get { return new DocumentWithSymbols(@class.Document); }
        }

        public int EndLine
        {
            get { return @class.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@class.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@class.Solution); }
        }

        public int StartLine
        {
            get { return @class.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public IClassDeclarationWithSymbols AsInterface()
        {
            return @class;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @class.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
