using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractTypeWithCodeAnalysis<TClass> : AbstractTypeWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly AbstractClassEventCollectionWithCodeAnalysis events;
        private readonly AbstractClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly AbstractClassMethodCollectionWithCodeAnalysis methods;
        private readonly AbstractClassPropertyCollectionWithCodeAnalysis properties;
        
        internal InternalAbstractTypeWithCodeAnalysis(TClass @class)
        {
            classType = new InternalClassTypeWithCodeAnalysis<TClass>(@class);
            members = classType.Members;
            events = new InternalAbstractClassEventCollectionWithCodeAnalysis<TClass>(classType);
            indexers = new InternalAbstractClassIndexerCollectionWithCodeAnalysis<TClass>(classType);
            methods = new InternalAbstractClassMethodCollectionWithCodeAnalysis<TClass>(classType);
            properties = new InternalAbstractClassPropertyCollectionWithCodeAnalysis<TClass>(classType);
            InitializeMembers();            
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return classType.BaseClass; }
            set { classType.BaseClass = value; }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classType.Constructors; }
            set { classType.Constructors = value; }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classType.ConversionOperators; }
            set { classType.ConversionOperators = value; }
        }

        public override ICollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override ICollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override AbstractClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.AbstractEvents), value.AbstractEvents.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.ExplicitInterfaceEvents), value.ExplicitInterfaceEvents.Select(@event => @event.Syntax)));
            }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return classType.ImplementedInterfaces; }
            set { classType.ImplementedInterfaces = value; }
        }

        public override AbstractClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.AbstractIndexers), value.AbstractIndexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax)));
            }
        }

        public override ICollection<ClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override AbstractClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.AbstractMethods), value.AbstractMethods.Select(method => method.Syntax)),
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(method => method.Syntax)),
                    new MemberListSyntax(nameof(methods.ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(method => method.Syntax)));
            }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classType.OperatorOverloads; }
            set { classType.OperatorOverloads = value; }
        }

        public override AbstractClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.AbstractProperties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(property => property.Syntax)));
            }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
        }

        public override ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        internal InternalClassTypeWithCodeAnalysis<TClass> Type
        {
            get { return classType; }
        }

        private void InitializeMembers()
        {
            members.InsertBefore(
                nameof(events.Events),
                nameof(events.AbstractEvents),
                () => events.AbstractEvents.Select(item => item.Syntax));
            members.Replace(nameof(events.Events), () => events.Events.Select(item => item.Syntax));
            members.InsertBefore(
                nameof(indexers.Indexers),
                nameof(indexers.AbstractIndexers),
                () => events.AbstractEvents.Select(item => item.Syntax));
            members.Replace(nameof(indexers.Indexers), () => indexers.Indexers.Select(item => item.Syntax));
            members.InsertBefore(
                nameof(methods.Methods),
                nameof(methods.AbstractMethods),
                () => methods.AbstractMethods.Select(item => item.Syntax));
            members.Replace(nameof(methods.Methods), () => methods.Methods.Select(item => item.Syntax));
            members.InsertBefore(
                nameof(properties.Properties),
                nameof(properties.AbstractProperties),
                () => properties.AbstractProperties.Select(item => item.Syntax));
            members.Replace(nameof(properties.Properties), () => properties.Properties.Select(item => item.Syntax));
        }
    }
}
