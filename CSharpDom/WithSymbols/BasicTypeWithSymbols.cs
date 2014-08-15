using System;
using System.Collections.Generic;

namespace CSharpDom.WithSymbols
{
    public abstract class BasicTypeWithSymbols : AbstractSymbolNode<IBasicTypeWithSymbols>
    {
        private readonly IBasicTypeWithSymbols type;

        public BasicTypeWithSymbols(IBasicTypeWithSymbols type)
            : base(type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<EventWithSymbols> Events
        {
            get
            {
                return new ReadOnlyNodeCollection<EventWithSymbols, IEventWithSymbols>(
                    type.Events,
                    @event => new EventWithSymbols(@event));
            }
        }

        public IReadOnlyCollection<IndexerWithSymbols> Indexers
        {
            get
            {
                return new ReadOnlyNodeCollection<IndexerWithSymbols, IIndexerWithSymbols>(
                    type.Indexers,
                    indexer => new IndexerWithSymbols(indexer));
            }
        }

        public bool IsNestedType
        {
            get { return type.IsNestedType; }
        }

        public IReadOnlyCollection<MethodWithSymbols> Methods
        {
            get
            {
                return new ReadOnlyNodeCollection<MethodWithSymbols, IMethodWithSymbols>(
                   type.Methods,
                   method => new MethodWithSymbols(method));
            }
        }

        public IReadOnlyCollection<PropertyWithSymbols> Properties
        {
            get
            {
                return new ReadOnlyNodeCollection<PropertyWithSymbols, IPropertyWithSymbols>(
                   type.Properties,
                   property => new PropertyWithSymbols(property));
            }
        }

        internal static BasicTypeWithSymbols GetBasicType(IBasicTypeWithSymbols type)
        {
            return type.IsNestedType ? GetNestedBasicType(type) : GetNonNestedBasicType(type);
        }

        private static BasicTypeWithSymbols GetNonNestedBasicType(IBasicTypeWithSymbols type)
        {
            return GetBasicType<IClassDeclarationWithSymbols>(type, CreateClassDeclarationWithSymbols) ??
                GetBasicType<IClassWithSymbols>(type, CreateClassWithSymbols) ??
                GetBasicType<IInterfaceDeclarationWithSymbols>(type, CreateInterfaceDeclarationWithSymbols) ??
                GetBasicType<IInterfaceWithSymbols>(type, CreateInterfaceWithSymbols) ??
                GetBasicType<IStructDeclarationWithSymbols>(type, CreateStructDeclarationWithSymbols) ??
                GetBasicType<IStructWithSymbols>(type, CreateStructWithSymbols);
        }

        private static BasicTypeWithSymbols GetNestedBasicType(IBasicTypeWithSymbols type)
        {
            return GetBasicType<INestedClassDeclarationWithSymbols>(type, CreateNestedClassDeclarationWithSymbols) ??
                GetBasicType<INestedClassWithSymbols>(type, CreateNestedClassWithSymbols) ??
                GetBasicType<INestedInterfaceDeclarationWithSymbols>(type, CreateNestedInterfaceDeclarationWithSymbols) ??
                GetBasicType<INestedInterfaceWithSymbols>(type, CreateNestedInterfaceWithSymbols) ??
                GetBasicType<INestedStructDeclarationWithSymbols>(type, CreateNestedStructDeclarationWithSymbols) ??
                GetBasicType<INestedStructWithSymbols>(type, CreateNestedStructWithSymbols);
        }

        private static BasicTypeWithSymbols GetBasicType<T>(
            IBasicTypeWithSymbols type,
            Func<T, BasicTypeWithSymbols> factory)
            where T : class
        {
            T newType = type as T;
            return newType == null ? null : factory(newType);
        }

        private static BasicTypeWithSymbols CreateClassDeclarationWithSymbols(IClassDeclarationWithSymbols @class)
        {
            return new ClassDeclarationWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateClassWithSymbols(IClassWithSymbols @class)
        {
            return new ClassWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateInterfaceDeclarationWithSymbols(
            IInterfaceDeclarationWithSymbols @interface)
        {
            return new InterfaceDeclarationWithSymbols(@interface);
        }

        private static BasicTypeWithSymbols CreateInterfaceWithSymbols(IInterfaceWithSymbols @interface)
        {
            return new InterfaceWithSymbols(@interface);
        }

        private static BasicTypeWithSymbols CreateStructDeclarationWithSymbols(
            IStructDeclarationWithSymbols @class)
        {
            return new StructDeclarationWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateStructWithSymbols(IStructWithSymbols @class)
        {
            return new StructWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateNestedClassDeclarationWithSymbols(
            INestedClassDeclarationWithSymbols @class)
        {
            return new NestedClassDeclarationWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateNestedClassWithSymbols(INestedClassWithSymbols @class)
        {
            return new NestedClassWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateNestedInterfaceDeclarationWithSymbols(
            INestedInterfaceDeclarationWithSymbols @interface)
        {
            return new NestedInterfaceDeclarationWithSymbols(@interface);
        }

        private static BasicTypeWithSymbols CreateNestedInterfaceWithSymbols(INestedInterfaceWithSymbols @interface)
        {
            return new NestedInterfaceWithSymbols(@interface);
        }

        private static BasicTypeWithSymbols CreateNestedStructDeclarationWithSymbols(
            INestedStructDeclarationWithSymbols @class)
        {
            return new NestedStructDeclarationWithSymbols(@class);
        }

        private static BasicTypeWithSymbols CreateNestedStructWithSymbols(INestedStructWithSymbols @class)
        {
            return new NestedStructWithSymbols(@class);
        }
    }
}
