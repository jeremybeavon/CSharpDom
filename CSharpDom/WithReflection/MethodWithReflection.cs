using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class MethodWithReflection
    {
        private readonly IMethodWithReflection method;

        public MethodWithReflection(IMethodWithReflection method)
        {
            this.method = method;
        }

        public MethodDeclarationSyntax Declaration
        {
            get { return method.Declaration; }
        }

        public BasicTypeWithReflection DeclaringType
        {
            get { return BasicTypeWithReflection.GetBasicType(method.DeclaringType); }
        }

        public int EndLine
        {
            get { return method.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return method.GenericParameterCount; }
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

        public IMethodWithReflection AsInterface()
        {
            return method;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            method.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return method.ToString();
        }
    }
}
