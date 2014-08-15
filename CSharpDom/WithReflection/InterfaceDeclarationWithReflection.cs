using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class InterfaceDeclarationWithReflection : BasicTypeWithReflection
    {
        private readonly IInterfaceDeclarationWithReflection @interface;

        public InterfaceDeclarationWithReflection(IInterfaceDeclarationWithReflection @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public InterfaceWithReflection CompositeType
        {
            get { return new InterfaceWithReflection(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public DocumentWithReflection Document
        {
            get { return new DocumentWithReflection(@interface.Document); }
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

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@interface.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@interface.Solution); }
        }

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @interface.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @interface.ToString();
        }
    }
}
