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
    public sealed class ClassDeclarationWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly IClassDeclarationWithLinqExpressions @class;

        public ClassDeclarationWithLinqExpressions(IClassDeclarationWithLinqExpressions @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public ClassWithLinqExpressions CompositeType
        {
            get { return new ClassWithLinqExpressions(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public DestructorWithLinqExpressions Destructor
        {
            get { return new DestructorWithLinqExpressions(@class.Destructor); }
        }

        public DocumentWithLinqExpressions Document
        {
            get { return new DocumentWithLinqExpressions(@class.Document); }
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

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@class.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@class.Solution); }
        }

        public int StartLine
        {
            get { return @class.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public IClassDeclarationWithLinqExpressions AsInterface()
        {
            return @class;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @class.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @class.ToString();
        }
    }
}
