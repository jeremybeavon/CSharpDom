using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NamespaceWithLinqExpressions
    {
        private readonly INamespaceWithLinqExpressions @namespace;

        public NamespaceWithLinqExpressions(INamespaceWithLinqExpressions @namespace)
        {
            this.@namespace = @namespace;
        }

        public IReadOnlyCollection<ClassWithLinqExpressions> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassWithLinqExpressions, IClassWithLinqExpressions>(
                    @namespace.Classes,
                    @class => new ClassWithLinqExpressions(@class));
            }
        }

        public IEnumerable<NamespaceDeclarationSyntax> Declarations
        {
            get { return @namespace.Declarations; }
        }

        public IReadOnlyCollection<DelegateWithLinqExpressions> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<DelegateWithLinqExpressions, IDelegateWithLinqExpressions>(
                    @namespace.Delegates,
                    @delegate => new DelegateWithLinqExpressions(@delegate));
            }
        }

        public IReadOnlyCollection<EnumWithLinqExpressions> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumWithLinqExpressions, IEnumWithLinqExpressions>(
                    @namespace.Enums,
                    @enum => new EnumWithLinqExpressions(@enum));
            }
        }

        public IReadOnlyCollection<InterfaceWithLinqExpressions> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceWithLinqExpressions, IInterfaceWithLinqExpressions>(
                    @namespace.Interfaces,
                    @interface => new InterfaceWithLinqExpressions(@interface));
            }
        }

        public string Name
        {
            get { return @namespace.Name; }
        }

        public IReadOnlyCollection<StructWithLinqExpressions> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<StructWithLinqExpressions, IStructWithLinqExpressions>(
                    @namespace.Structs,
                    @struct => new StructWithLinqExpressions(@struct));
            }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @namespace.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @namespace.ToString();
        }
    }
}
