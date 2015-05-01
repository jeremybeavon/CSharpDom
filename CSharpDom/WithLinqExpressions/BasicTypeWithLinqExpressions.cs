using System;
using System.Collections.Generic;

namespace CSharpDom.WithLinqExpressions
{
    public abstract class BasicTypeWithLinqExpressions
    {
        private readonly IBasicTypeWithLinqExpressions type;

        public BasicTypeWithLinqExpressions(IBasicTypeWithLinqExpressions type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<EventWithLinqExpressions> Events
        {
            get
            {
                return new ReadOnlyNodeCollection<EventWithLinqExpressions, IEventWithLinqExpressions>(
                    type.Events,
                    @event => new EventWithLinqExpressions(@event));
            }
        }

        public IReadOnlyCollection<IndexerWithLinqExpressions> Indexers
        {
            get
            {
                return new ReadOnlyNodeCollection<IndexerWithLinqExpressions, IIndexerWithLinqExpressions>(
                    type.Indexers,
                    indexer => new IndexerWithLinqExpressions(indexer));
            }
        }

        public bool IsNestedType
        {
            get { return type.IsNestedType; }
        }

        public IReadOnlyCollection<MethodWithLinqExpressions> Methods
        {
            get
            {
                return new ReadOnlyNodeCollection<MethodWithLinqExpressions, IMethodWithLinqExpressions>(
                   type.Methods,
                   method => new MethodWithLinqExpressions(method));
            }
        }

        public IReadOnlyCollection<PropertyWithLinqExpressions> Properties
        {
            get
            {
                return new ReadOnlyNodeCollection<PropertyWithLinqExpressions, IPropertyWithLinqExpressions>(
                   type.Properties,
                   property => new PropertyWithLinqExpressions(property));
            }
        }

        internal static BasicTypeWithLinqExpressions GetBasicType(IBasicTypeWithLinqExpressions type)
        {
            return type.IsNestedType ? GetNestedBasicType(type) : GetNonNestedBasicType(type);
        }

        private static BasicTypeWithLinqExpressions GetNonNestedBasicType(IBasicTypeWithLinqExpressions type)
        {
            return GetBasicType<IClassDeclarationWithLinqExpressions>(type, CreateClassDeclarationWithLinqExpressions) ??
                GetBasicType<IClassWithLinqExpressions>(type, CreateClassWithLinqExpressions) ??
                GetBasicType<IInterfaceDeclarationWithLinqExpressions>(type, CreateInterfaceDeclarationWithLinqExpressions) ??
                GetBasicType<IInterfaceWithLinqExpressions>(type, CreateInterfaceWithLinqExpressions) ??
                GetBasicType<IStructDeclarationWithLinqExpressions>(type, CreateStructDeclarationWithLinqExpressions) ??
                GetBasicType<IStructWithLinqExpressions>(type, CreateStructWithLinqExpressions);
        }

        private static BasicTypeWithLinqExpressions GetNestedBasicType(IBasicTypeWithLinqExpressions type)
        {
            return GetBasicType<INestedClassDeclarationWithLinqExpressions>(type, CreateNestedClassDeclarationWithLinqExpressions) ??
                GetBasicType<INestedClassWithLinqExpressions>(type, CreateNestedClassWithLinqExpressions) ??
                GetBasicType<INestedInterfaceDeclarationWithLinqExpressions>(type, CreateNestedInterfaceDeclarationWithLinqExpressions) ??
                GetBasicType<INestedInterfaceWithLinqExpressions>(type, CreateNestedInterfaceWithLinqExpressions) ??
                GetBasicType<INestedStructDeclarationWithLinqExpressions>(type, CreateNestedStructDeclarationWithLinqExpressions) ??
                GetBasicType<INestedStructWithLinqExpressions>(type, CreateNestedStructWithLinqExpressions);
        }

        private static BasicTypeWithLinqExpressions GetBasicType<T>(
            IBasicTypeWithLinqExpressions type,
            Func<T, BasicTypeWithLinqExpressions> factory)
            where T : class
        {
            T newType = type as T;
            return newType == null ? null : factory(newType);
        }

        private static BasicTypeWithLinqExpressions CreateClassDeclarationWithLinqExpressions(
            IClassDeclarationWithLinqExpressions @class)
        {
            return new ClassDeclarationWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateClassWithLinqExpressions(IClassWithLinqExpressions @class)
        {
            return new ClassWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateInterfaceDeclarationWithLinqExpressions(
            IInterfaceDeclarationWithLinqExpressions @interface)
        {
            return new InterfaceDeclarationWithLinqExpressions(@interface);
        }

        private static BasicTypeWithLinqExpressions CreateInterfaceWithLinqExpressions(IInterfaceWithLinqExpressions @interface)
        {
            return new InterfaceWithLinqExpressions(@interface);
        }

        private static BasicTypeWithLinqExpressions CreateStructDeclarationWithLinqExpressions(
            IStructDeclarationWithLinqExpressions @class)
        {
            return new StructDeclarationWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateStructWithLinqExpressions(IStructWithLinqExpressions @class)
        {
            return new StructWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateNestedClassDeclarationWithLinqExpressions(
            INestedClassDeclarationWithLinqExpressions @class)
        {
            return new NestedClassDeclarationWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateNestedClassWithLinqExpressions(INestedClassWithLinqExpressions @class)
        {
            return new NestedClassWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateNestedInterfaceDeclarationWithLinqExpressions(
            INestedInterfaceDeclarationWithLinqExpressions @interface)
        {
            return new NestedInterfaceDeclarationWithLinqExpressions(@interface);
        }

        private static BasicTypeWithLinqExpressions CreateNestedInterfaceWithLinqExpressions(
            INestedInterfaceWithLinqExpressions @interface)
        {
            return new NestedInterfaceWithLinqExpressions(@interface);
        }

        private static BasicTypeWithLinqExpressions CreateNestedStructDeclarationWithLinqExpressions(
            INestedStructDeclarationWithLinqExpressions @class)
        {
            return new NestedStructDeclarationWithLinqExpressions(@class);
        }

        private static BasicTypeWithLinqExpressions CreateNestedStructWithLinqExpressions(INestedStructWithLinqExpressions @class)
        {
            return new NestedStructWithLinqExpressions(@class);
        }
    }
}
