using System;
using System.Collections.Generic;

namespace CSharpDom.WithSyntax
{
    public abstract class BasicTypeWithSyntax : AbstractSyntaxNode<IBasicTypeSyntax>
    {
        private readonly IBasicTypeSyntax type;

        public BasicTypeWithSyntax(IBasicTypeSyntax type)
            : base(type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<EventWithSyntax> Events
        {
            get
            {
                return new ReadOnlyNodeCollection<EventWithSyntax, IEventSyntax>(
                    type.Events,
                    @event => new EventWithSyntax(@event));
            }
        }

        public IReadOnlyCollection<IndexerWithSyntax> Indexers
        {
            get
            {
                return new ReadOnlyNodeCollection<IndexerWithSyntax, IIndexerSyntax>(
                    type.Indexers,
                    indexer => new IndexerWithSyntax(indexer));
            }
        }

        public bool IsNestedType
        {
            get { return type.IsNestedType; }
        }

        public IReadOnlyCollection<MethodWithSyntax> Methods
        {
            get
            {
                return new ReadOnlyNodeCollection<MethodWithSyntax, IMethodSyntax>(
                   type.Methods,
                   method => new MethodWithSyntax(method));
            }
        }

        public IReadOnlyCollection<PropertyWithSyntax> Properties
        {
            get
            {
                return new ReadOnlyNodeCollection<PropertyWithSyntax, IPropertySyntax>(
                   type.Properties,
                   property => new PropertyWithSyntax(property));
            }
        }

        internal static BasicTypeWithSyntax GetBasicType(IBasicTypeSyntax type)
        {
            return type.IsNestedType ? GetNestedBasicType(type) : GetNonNestedBasicType(type);
        }

        private static BasicTypeWithSyntax GetNonNestedBasicType(IBasicTypeSyntax type)
        {
            return GetBasicType<IClassDeclarationSyntax>(type, CreateClassDeclarationWithSyntax) ??
                GetBasicType<IClassSyntax>(type, CreateClassWithSyntax) ??
                GetBasicType<IInterfaceDeclarationSyntax>(type, CreateInterfaceDeclarationWithSyntax) ??
                GetBasicType<IInterfaceSyntax>(type, CreateInterfaceWithSyntax) ??
                GetBasicType<IStructDeclarationSyntax>(type, CreateStructDeclarationWithSyntax) ??
                GetBasicType<IStructSyntax>(type, CreateStructWithSyntax);
        }

        private static BasicTypeWithSyntax GetNestedBasicType(IBasicTypeSyntax type)
        {
            return GetBasicType<INestedClassDeclarationSyntax>(type, CreateNestedClassDeclarationWithSyntax) ??
                GetBasicType<INestedClassSyntax>(type, CreateNestedClassWithSyntax) ??
                GetBasicType<INestedInterfaceDeclarationSyntax>(type, CreateNestedInterfaceDeclarationWithSyntax) ??
                GetBasicType<INestedInterfaceSyntax>(type, CreateNestedInterfaceWithSyntax) ??
                GetBasicType<INestedStructDeclarationSyntax>(type, CreateNestedStructDeclarationWithSyntax) ??
                GetBasicType<INestedStructSyntax>(type, CreateNestedStructWithSyntax);
        }

        private static BasicTypeWithSyntax GetBasicType<T>(IBasicTypeSyntax type, Func<T, BasicTypeWithSyntax> factory)
            where T : class
        {
            T newType = type as T;
            return newType == null ? null : factory(newType);
        }

        private static BasicTypeWithSyntax CreateClassDeclarationWithSyntax(IClassDeclarationSyntax @class)
        {
            return new ClassDeclarationWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateClassWithSyntax(IClassSyntax @class)
        {
            return new ClassWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateInterfaceDeclarationWithSyntax(
            IInterfaceDeclarationSyntax @interface)
        {
            return new InterfaceDeclarationWithSyntax(@interface);
        }

        private static BasicTypeWithSyntax CreateInterfaceWithSyntax(IInterfaceSyntax @interface)
        {
            return new InterfaceWithSyntax(@interface);
        }

        private static BasicTypeWithSyntax CreateStructDeclarationWithSyntax(
            IStructDeclarationSyntax @class)
        {
            return new StructDeclarationWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateStructWithSyntax(IStructSyntax @class)
        {
            return new StructWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateNestedClassDeclarationWithSyntax(INestedClassDeclarationSyntax @class)
        {
            return new NestedClassDeclarationWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateNestedClassWithSyntax(INestedClassSyntax @class)
        {
            return new NestedClassWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateNestedInterfaceDeclarationWithSyntax(
            INestedInterfaceDeclarationSyntax @interface)
        {
            return new NestedInterfaceDeclarationWithSyntax(@interface);
        }

        private static BasicTypeWithSyntax CreateNestedInterfaceWithSyntax(INestedInterfaceSyntax @interface)
        {
            return new NestedInterfaceWithSyntax(@interface);
        }

        private static BasicTypeWithSyntax CreateNestedStructDeclarationWithSyntax(
            INestedStructDeclarationSyntax @class)
        {
            return new NestedStructDeclarationWithSyntax(@class);
        }

        private static BasicTypeWithSyntax CreateNestedStructWithSyntax(INestedStructSyntax @class)
        {
            return new NestedStructWithSyntax(@class);
        }
    }
}
