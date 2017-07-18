using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class AbstractPartialTypeWithCodeAnalysis<TClass> :
        EditableAbstractType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AbstractPartialClassEventCollectionWithCodeAnalysis,
            AbstractPartialClassPropertyCollectionWithCodeAnalysis,
            AbstractPartialClassIndexerCollectionWithCodeAnalysis,
            AbstractPartialClassMethodCollectionWithCodeAnalysis,
            AbstractPartialClassFieldCollectionWithCodeAnalysis,
            AbstractPartialClassConstructorWithCodeAnalysis,
            AbstractPartialClassOperatorOverloadWithCodeAnalysis,
            AbstractPartialClassConversionOperatorWithCodeAnalysis,
            AbstractPartialClassNestedClassCollectionWithCodeAnalysis,
            AbstractPartialClassNestedDelegateWithCodeAnalysis,
            AbstractPartialClassNestedEnumWithCodeAnalysis,
            AbstractPartialClassNestedInterfaceWithCodeAnalysis,
            AbstractPartialClassNestedStructCollectionWithCodeAnalysis,
            AbstractPartialClassStaticConstructorWithCodeAnalysis,
            AbstractPartialClassDestructorWithCodeAnalysis>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalAbstractTypeWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly AbstractPartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            ClassConstructorWithCodeAnalysis,
            AbstractPartialClassConstructorWithCodeAnalysis> constructors;
        private readonly WrappedCollection<
            ClassConversionOperatorWithCodeAnalysis,
            AbstractPartialClassConversionOperatorWithCodeAnalysis> conversionOperators;
        private readonly WrappedCollection<
            ClassNestedDelegateWithCodeAnalysis,
            AbstractPartialClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            ClassNestedEnumWithCodeAnalysis,
            AbstractPartialClassNestedEnumWithCodeAnalysis> enums;
        private readonly AbstractPartialClassEventCollectionWithCodeAnalysis events;
        private readonly AbstractPartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly AbstractPartialClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly WrappedCollection<
            ClassNestedInterfaceWithCodeAnalysis,
            AbstractPartialClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly AbstractPartialClassMethodCollectionWithCodeAnalysis methods;
        private readonly WrappedCollection<
            ClassOperatorOverloadWithCodeAnalysis,
            AbstractPartialClassOperatorOverloadWithCodeAnalysis> operatorOverloads;
        private readonly AbstractPartialClassPropertyCollectionWithCodeAnalysis properties;
        private readonly AbstractPartialClassNestedStructCollectionWithCodeAnalysis structs;

        internal AbstractPartialTypeWithCodeAnalysis(InternalNestedAbstractClassWithCodeAnalysis<TClass> classType)
            : this(classType.InternalClass)
        {
        }

        internal AbstractPartialTypeWithCodeAnalysis(InternalAbstractTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            members = classType.Members;
            classes = new AbstractPartialClassNestedClassCollectionWithCodeAnalysis(classType.Type.Classes);
            constructors = new WrappedCollection<ClassConstructorWithCodeAnalysis, AbstractPartialClassConstructorWithCodeAnalysis>(
                classType.Type.Constructors,
                constructor => new AbstractPartialClassConstructorWithCodeAnalysis(constructor),
                constructor => constructor.Constructor,
                value => classType.Type.Constructors = value);
            conversionOperators = new WrappedCollection<ClassConversionOperatorWithCodeAnalysis, AbstractPartialClassConversionOperatorWithCodeAnalysis>(
                classType.Type.ConversionOperators,
                parent => new AbstractPartialClassConversionOperatorWithCodeAnalysis(parent),
                child => child.InternalConversionOperator,
                value => classType.Type.ConversionOperators = value);
            delegates = new WrappedCollection<ClassNestedDelegateWithCodeAnalysis, AbstractPartialClassNestedDelegateWithCodeAnalysis>(
                classType.Type.Delegates,
                parent => new AbstractPartialClassNestedDelegateWithCodeAnalysis(parent),
                child => child.InternalDelegate,
                value => classType.Type.Delegates = value);
            enums = new WrappedCollection<ClassNestedEnumWithCodeAnalysis, AbstractPartialClassNestedEnumWithCodeAnalysis>(
                classType.Type.Enums,
                parent => new AbstractPartialClassNestedEnumWithCodeAnalysis(parent),
                child => child.InternalEnum,
                value => classType.Type.Enums = value);
            events = new AbstractPartialClassEventCollectionWithCodeAnalysis(classType.Events);
            fields = new AbstractPartialClassFieldCollectionWithCodeAnalysis(classType.Type.Fields);
            indexers = new AbstractPartialClassIndexerCollectionWithCodeAnalysis(classType.Indexers);
            interfaces = new WrappedCollection<ClassNestedInterfaceWithCodeAnalysis, AbstractPartialClassNestedInterfaceWithCodeAnalysis>(
                classType.Type.Interfaces,
                parent => new AbstractPartialClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.InternalInterface,
                value => classType.Type.Interfaces = value);
            methods = new InternalAbstractPartialClassMethodCollectionWithCodeAnalysis<TClass>(classType.Type);
            operatorOverloads = new WrappedCollection<ClassOperatorOverloadWithCodeAnalysis, AbstractPartialClassOperatorOverloadWithCodeAnalysis>(
                classType.Type.OperatorOverloads,
                parent => new AbstractPartialClassOperatorOverloadWithCodeAnalysis(parent),
                child => child.InternalOperatorOverload,
                value => classType.Type.OperatorOverloads = value);
            properties = new AbstractPartialClassPropertyCollectionWithCodeAnalysis(classType.Properties);
            structs = new AbstractPartialClassNestedStructCollectionWithCodeAnalysis(classType.Type.Structs);
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

        public override AbstractPartialClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<AbstractPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { constructors.Replace(value); }
        }

        public override ICollection<AbstractPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { conversionOperators.Replace(value); }
        }

        public override ICollection<AbstractPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { delegates.Replace(value); }
        }

        public override AbstractPartialClassDestructorWithCodeAnalysis Destructor
        {
            get
            {
                ClassDestructorWithCodeAnalysis destructor = classType.Type.Destructor;
                return destructor == null ? null : new AbstractPartialClassDestructorWithCodeAnalysis(destructor);
            }
            set { classType.Type.Destructor = value?.InternalDestructor; }
        }

        public override ICollection<AbstractPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { enums.Replace(value); }
        }

        public override AbstractPartialClassEventCollectionWithCodeAnalysis Events
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

        public override AbstractPartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override AbstractPartialClassIndexerCollectionWithCodeAnalysis Indexers
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

        public override ICollection<AbstractPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.Replace(value); }
        }

        public override AbstractPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set { classType.Type.Members.Replace(value); }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<AbstractPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { operatorOverloads.Replace(value); }
        }

        public override AbstractPartialClassPropertyCollectionWithCodeAnalysis Properties
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

        public override AbstractPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get
            {
                ClassStaticConstructorWithCodeAnalysis constructor = classType.Type.StaticConstructor;
                return constructor == null ? null : new AbstractPartialClassStaticConstructorWithCodeAnalysis(constructor);
            }
            set { classType.Type.StaticConstructor = value?.InternalStaticConstructor; }
        }

        public override AbstractPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }
    }
}
