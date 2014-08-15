using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class NamespaceWithReflection
    {
        private readonly INamespaceWithReflection @namespace;

        public NamespaceWithReflection(INamespaceWithReflection @namespace)
        {
            this.@namespace = @namespace;
        }

        public IReadOnlyCollection<ClassWithReflection> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassWithReflection, IClassWithReflection>(
                    @namespace.Classes,
                    @class => new ClassWithReflection(@class));
            }
        }

        public IEnumerable<NamespaceDeclarationSyntax> Declarations
        {
            get { return @namespace.Declarations; }
        }

        public IReadOnlyCollection<DelegateWithReflection> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<DelegateWithReflection, IDelegateWithReflection>(
                    @namespace.Delegates,
                    @delegate => new DelegateWithReflection(@delegate));
            }
        }

        public IReadOnlyCollection<EnumWithReflection> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumWithReflection, IEnumWithReflection>(
                    @namespace.Enums,
                    @enum => new EnumWithReflection(@enum));
            }
        }

        public IReadOnlyCollection<InterfaceWithReflection> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceWithReflection, IInterfaceWithReflection>(
                    @namespace.Interfaces,
                    @interface => new InterfaceWithReflection(@interface));
            }
        }

        public string Name
        {
            get { return @namespace.Name; }
        }

        public IReadOnlyCollection<StructWithReflection> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<StructWithReflection, IStructWithReflection>(
                    @namespace.Structs,
                    @struct => new StructWithReflection(@struct));
            }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @namespace.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @namespace.ToString();
        }
    }
}
