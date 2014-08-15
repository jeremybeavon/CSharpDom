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
    public sealed class ClassDeclarationWithReflection : TypeWithReflection
    {
        private readonly IClassDeclarationWithReflection @class;

        public ClassDeclarationWithReflection(IClassDeclarationWithReflection @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public ClassWithReflection CompositeType
        {
            get { return new ClassWithReflection(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public DestructorWithReflection Destructor
        {
            get { return new DestructorWithReflection(@class.Destructor); }
        }

        public DocumentWithReflection Document
        {
            get { return new DocumentWithReflection(@class.Document); }
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

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@class.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@class.Solution); }
        }

        public int StartLine
        {
            get { return @class.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public IClassDeclarationWithReflection AsInterface()
        {
            return @class;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @class.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @class.ToString();
        }
    }
}
