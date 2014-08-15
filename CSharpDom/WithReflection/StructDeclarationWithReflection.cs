using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class StructDeclarationWithReflection : TypeWithReflection
    {
        private IStructDeclarationWithReflection @struct;

        public StructDeclarationWithReflection(IStructDeclarationWithReflection @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public StructWithReflection CompositeType
        {
            get { return new StructWithReflection(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public DocumentWithReflection Document
        {
            get { return new DocumentWithReflection(@struct.Document); }
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

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@struct.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@struct.Solution); }
        }

        public int StartLine
        {
            get { return @struct.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @struct.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
