using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class StructDeclarationWithLinqExpressions : TypeWithLinqExpressions
    {
        private IStructDeclarationWithLinqExpressions @struct;

        public StructDeclarationWithLinqExpressions(IStructDeclarationWithLinqExpressions @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public StructWithLinqExpressions CompositeType
        {
            get { return new StructWithLinqExpressions(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public DocumentWithLinqExpressions Document
        {
            get { return new DocumentWithLinqExpressions(@struct.Document); }
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

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@struct.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@struct.Solution); }
        }

        public int StartLine
        {
            get { return @struct.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @struct.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
