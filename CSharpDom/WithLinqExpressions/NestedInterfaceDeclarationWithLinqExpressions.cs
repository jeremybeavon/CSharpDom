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
    public sealed class NestedInterfaceDeclarationWithLinqExpressions : BasicTypeWithLinqExpressions
    {
        private readonly INestedInterfaceDeclarationWithLinqExpressions @interface;

        public NestedInterfaceDeclarationWithLinqExpressions(INestedInterfaceDeclarationWithLinqExpressions @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public NestedInterfaceWithLinqExpressions CompositeType
        {
            get { return new NestedInterfaceWithLinqExpressions(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(@interface.DeclaringType); }
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

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public INestedInterfaceDeclarationWithLinqExpressions AsInterface()
        {
            return @interface;
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
