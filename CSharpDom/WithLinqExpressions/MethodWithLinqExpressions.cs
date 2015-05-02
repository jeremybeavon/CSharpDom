using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class MethodWithLinqExpressions
    {
        private readonly IMethodWithLinqExpressions method;

        public MethodWithLinqExpressions(IMethodWithLinqExpressions method)
        {
            this.method = method;
        }

        public MethodDeclarationSyntax Declaration
        {
            get { return method.Declaration; }
        }

        public BasicTypeWithLinqExpressions DeclaringType
        {
            get { return BasicTypeWithLinqExpressions.GetBasicType(method.DeclaringType); }
        }

        public int EndLine
        {
            get { return method.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return method.GenericParameterCount; }
        }

        public IImplementation Implementation
        {
            get { return method.Implementation; }
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

        public IMethodWithLinqExpressions AsInterface()
        {
            return method;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            method.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return method.ToString();
        }
    }
}
