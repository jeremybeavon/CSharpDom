using System;
using System.Collections.Generic;

namespace CSharpDom.WithReflection
{
    public abstract class BasicTypeWithReflection
    {
        private readonly IBasicTypeWithReflection type;

        public BasicTypeWithReflection(IBasicTypeWithReflection type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<EventWithReflection> Events
        {
            get
            {
                return new ReadOnlyNodeCollection<EventWithReflection, IEventWithReflection>(
                    type.Events,
                    @event => new EventWithReflection(@event));
            }
        }

        public IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get
            {
                return new ReadOnlyNodeCollection<IndexerWithReflection, IIndexerWithReflection>(
                    type.Indexers,
                    indexer => new IndexerWithReflection(indexer));
            }
        }

        public bool IsNestedType
        {
            get { return type.IsNestedType; }
        }

        public IReadOnlyCollection<MethodWithReflection> Methods
        {
            get
            {
                return new ReadOnlyNodeCollection<MethodWithReflection, IMethodWithReflection>(
                   type.Methods,
                   method => new MethodWithReflection(method));
            }
        }

        public IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get
            {
                return new ReadOnlyNodeCollection<PropertyWithReflection, IPropertyWithReflection>(
                   type.Properties,
                   property => new PropertyWithReflection(property));
            }
        }

        internal static BasicTypeWithReflection GetBasicType(IBasicTypeWithReflection type)
        {
            return type.IsNestedType ? GetNestedBasicType(type) : GetNonNestedBasicType(type);
        }

        private static BasicTypeWithReflection GetNonNestedBasicType(IBasicTypeWithReflection type)
        {
            return GetBasicType<IClassDeclarationWithReflection>(type, CreateClassDeclarationWithReflection) ??
                GetBasicType<IClassWithReflection>(type, CreateClassWithReflection) ??
                GetBasicType<IInterfaceDeclarationWithReflection>(type, CreateInterfaceDeclarationWithReflection) ??
                GetBasicType<IInterfaceWithReflection>(type, CreateInterfaceWithReflection) ??
                GetBasicType<IStructDeclarationWithReflection>(type, CreateStructDeclarationWithReflection) ??
                GetBasicType<IStructWithReflection>(type, CreateStructWithReflection);
        }

        private static BasicTypeWithReflection GetNestedBasicType(IBasicTypeWithReflection type)
        {
            return GetBasicType<INestedClassDeclarationWithReflection>(type, CreateNestedClassDeclarationWithReflection) ??
                GetBasicType<INestedClassWithReflection>(type, CreateNestedClassWithReflection) ??
                GetBasicType<INestedInterfaceDeclarationWithReflection>(type, CreateNestedInterfaceDeclarationWithReflection) ??
                GetBasicType<INestedInterfaceWithReflection>(type, CreateNestedInterfaceWithReflection) ??
                GetBasicType<INestedStructDeclarationWithReflection>(type, CreateNestedStructDeclarationWithReflection) ??
                GetBasicType<INestedStructWithReflection>(type, CreateNestedStructWithReflection);
        }

        private static BasicTypeWithReflection GetBasicType<T>(
            IBasicTypeWithReflection type,
            Func<T, BasicTypeWithReflection> factory)
            where T : class
        {
            T newType = type as T;
            return newType == null ? null : factory(newType);
        }

        private static BasicTypeWithReflection CreateClassDeclarationWithReflection(
            IClassDeclarationWithReflection @class)
        {
            return new ClassDeclarationWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateClassWithReflection(IClassWithReflection @class)
        {
            return new ClassWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateInterfaceDeclarationWithReflection(
            IInterfaceDeclarationWithReflection @interface)
        {
            return new InterfaceDeclarationWithReflection(@interface);
        }

        private static BasicTypeWithReflection CreateInterfaceWithReflection(IInterfaceWithReflection @interface)
        {
            return new InterfaceWithReflection(@interface);
        }

        private static BasicTypeWithReflection CreateStructDeclarationWithReflection(
            IStructDeclarationWithReflection @class)
        {
            return new StructDeclarationWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateStructWithReflection(IStructWithReflection @class)
        {
            return new StructWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateNestedClassDeclarationWithReflection(
            INestedClassDeclarationWithReflection @class)
        {
            return new NestedClassDeclarationWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateNestedClassWithReflection(INestedClassWithReflection @class)
        {
            return new NestedClassWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateNestedInterfaceDeclarationWithReflection(
            INestedInterfaceDeclarationWithReflection @interface)
        {
            return new NestedInterfaceDeclarationWithReflection(@interface);
        }

        private static BasicTypeWithReflection CreateNestedInterfaceWithReflection(
            INestedInterfaceWithReflection @interface)
        {
            return new NestedInterfaceWithReflection(@interface);
        }

        private static BasicTypeWithReflection CreateNestedStructDeclarationWithReflection(
            INestedStructDeclarationWithReflection @class)
        {
            return new NestedStructDeclarationWithReflection(@class);
        }

        private static BasicTypeWithReflection CreateNestedStructWithReflection(INestedStructWithReflection @class)
        {
            return new NestedStructWithReflection(@class);
        }
    }
}
