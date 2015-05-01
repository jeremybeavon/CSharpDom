using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class InterfaceDeclarationWithLinqExpressions : BasicTypeWithLinqExpressions
    {
        private readonly IInterfaceDeclarationWithLinqExpressions @interface;

        public InterfaceDeclarationWithLinqExpressions(IInterfaceDeclarationWithLinqExpressions @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public InterfaceWithLinqExpressions CompositeType
        {
            get { return new InterfaceWithLinqExpressions(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public DocumentWithLinqExpressions Document
        {
            get { return new DocumentWithLinqExpressions(@interface.Document); }
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

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@interface.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@interface.Solution); }
        }

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @interface.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @interface.ToString();
        }
    }
}
