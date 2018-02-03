using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractTypeWithCodeAnalysis<TClass> : AbstractTypeWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly AbstractClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            ClassConstructorWithCodeAnalysis,
            AbstractClassConstructorWithCodeAnalysis> constructors;
        private readonly WrappedCollection<
            ClassConversionOperatorWithCodeAnalysis,
            AbstractClassConversionOperatorWithCodeAnalysis> conversionOperators;
        private readonly WrappedCollection<
            ClassNestedDelegateWithCodeAnalysis,
            AbstractClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            ClassNestedEnumWithCodeAnalysis,
            AbstractClassNestedEnumWithCodeAnalysis> enums;
        private readonly AbstractClassEventCollectionWithCodeAnalysis events;
        private readonly AbstractClassFieldCollectionWithCodeAnalysis fields;
        private readonly AbstractClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly WrappedCollection<
            ClassNestedInterfaceWithCodeAnalysis,
            AbstractClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly AbstractClassMethodCollectionWithCodeAnalysis methods;
        private readonly WrappedCollection<
            ClassOperatorOverloadWithCodeAnalysis,
            AbstractClassOperatorOverloadWithCodeAnalysis> operatorOverloads;
        private readonly AbstractClassPropertyCollectionWithCodeAnalysis properties;
        private readonly AbstractClassNestedStructCollectionWithCodeAnalysis structs;

        internal InternalAbstractTypeWithCodeAnalysis(TClass @class)
        {
            classType = new InternalClassTypeWithCodeAnalysis<TClass>(@class);
            members = classType.Members;
            classes = new AbstractClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            constructors = new WrappedCollection<ClassConstructorWithCodeAnalysis, AbstractClassConstructorWithCodeAnalysis>(
                classType.Constructors,
                constructor => new AbstractClassConstructorWithCodeAnalysis(constructor),
                constructor => constructor.Constructor,
                value => classType.Constructors = value);
            conversionOperators = new WrappedCollection<ClassConversionOperatorWithCodeAnalysis, AbstractClassConversionOperatorWithCodeAnalysis>(
                classType.ConversionOperators,
                parent => new AbstractClassConversionOperatorWithCodeAnalysis(parent),
                child => child.ConversionOperator,
                value => classType.ConversionOperators = value);
            delegates = new WrappedCollection<ClassNestedDelegateWithCodeAnalysis, AbstractClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new AbstractClassNestedDelegateWithCodeAnalysis(parent),
                child => child.Delegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<ClassNestedEnumWithCodeAnalysis, AbstractClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new AbstractClassNestedEnumWithCodeAnalysis(parent),
                child => child.Enum,
                value => classType.Enums = value);
            events = new InternalAbstractClassEventCollectionWithCodeAnalysis<TClass>(classType);
            fields = new AbstractClassFieldCollectionWithCodeAnalysis(classType.Fields);
            indexers = new InternalAbstractClassIndexerCollectionWithCodeAnalysis<TClass>(classType);
            interfaces = new WrappedCollection<ClassNestedInterfaceWithCodeAnalysis, AbstractClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new AbstractClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            methods = new InternalAbstractClassMethodCollectionWithCodeAnalysis<TClass>(classType);
            operatorOverloads = new WrappedCollection<ClassOperatorOverloadWithCodeAnalysis, AbstractClassOperatorOverloadWithCodeAnalysis>(
                classType.OperatorOverloads,
                parent => new AbstractClassOperatorOverloadWithCodeAnalysis(parent),
                child => child.OperatorOverload,
                value => classType.OperatorOverloads = value);
            properties = new InternalAbstractClassPropertyCollectionWithCodeAnalysis<TClass>(classType);
            structs = new AbstractClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
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

        public override AbstractClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.AbstractClasses), value.AbstractClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.StaticClasses), value.StaticClasses.Select(item => item.Syntax)));
            }
        }

        public override ICollection<AbstractClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { constructors.Replace(value); }
        }

        public override ICollection<AbstractClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { conversionOperators.Replace(value); }
        }

        public override ICollection<AbstractClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { delegates.Replace(value); }
        }

        public override AbstractClassDestructorWithCodeAnalysis Destructor
        {
            get
            {
                ClassDestructorWithCodeAnalysis destructor = classType.Destructor;
                return destructor == null ? null : new AbstractClassDestructorWithCodeAnalysis(destructor);
            }
            set { classType.Destructor = value?.Destructor; }
        }

        public override ICollection<AbstractClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { enums.Replace(value); }
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

        public override AbstractClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(fields.Constants), value.Constants.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(fields.Fields), value.Fields.Select(item => item.Syntax)));
            }
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

        public override ICollection<AbstractClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.Replace(value); }
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

        public override ICollection<AbstractClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { operatorOverloads.Replace(value); }
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

        public override AbstractClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get
            {
                ClassStaticConstructorWithCodeAnalysis constructor = classType.StaticConstructor;
                return constructor == null ? null : new AbstractClassStaticConstructorWithCodeAnalysis(constructor);
            }
            set { classType.StaticConstructor = value?.StaticConstructor; }
        }

        public override AbstractClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public override ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override IClassTypeWithCodeAnalysis Class => classType;

        internal InternalClassTypeWithCodeAnalysis<TClass> Type
        {
            get { return classType; }
        }

        internal IMemberList Members
        {
            get { return members; }
        }

        internal override INode<ClassDeclarationSyntax> Node => classType.Node;

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
