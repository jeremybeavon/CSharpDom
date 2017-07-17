using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class PartialClassTypeWithCodeAnalysis<TClass> :
        EditableClassType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            PartialClassEventCollectionWithCodeAnalysis,
            PartialClassPropertyCollectionWithCodeAnalysis,
            PartialClassIndexerCollectionWithCodeAnalysis,
            PartialClassMethodCollectionWithCodeAnalysis,
            PartialClassFieldCollectionWithCodeAnalysis,
            PartialClassConstructorWithCodeAnalysis,
            PartialClassOperatorOverloadWithCodeAnalysis,
            PartialClassConversionOperatorWithCodeAnalysis,
            PartialClassNestedClassCollectionWithCodeAnalysis,
            PartialClassNestedDelegateWithCodeAnalysis,
            PartialClassNestedEnumWithCodeAnalysis,
            PartialClassNestedInterfaceWithCodeAnalysis,
            PartialClassNestedStructCollectionWithCodeAnalysis,
            PartialClassStaticConstructorWithCodeAnalysis,
            PartialClassDestructorWithCodeAnalysis>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly PartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            ClassConstructorWithCodeAnalysis,
            PartialClassConstructorWithCodeAnalysis> constructors;
        private readonly WrappedCollection<
            ClassConversionOperatorWithCodeAnalysis,
            PartialClassConversionOperatorWithCodeAnalysis> conversionOperators;
        private readonly WrappedCollection<
            ClassNestedDelegateWithCodeAnalysis,
            PartialClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            ClassNestedEnumWithCodeAnalysis,
            PartialClassNestedEnumWithCodeAnalysis> enums;
        private readonly PartialClassEventCollectionWithCodeAnalysis events;
        private readonly PartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly PartialClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly WrappedCollection<
            ClassNestedInterfaceWithCodeAnalysis,
            PartialClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly WrappedCollection<
            ClassOperatorOverloadWithCodeAnalysis,
            PartialClassOperatorOverloadWithCodeAnalysis> operatorOverloads;
        private readonly PartialClassPropertyCollectionWithCodeAnalysis properties;
        private readonly PartialClassNestedStructCollectionWithCodeAnalysis structs;

        internal PartialClassTypeWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            members = classType.Members;
            classes = new PartialClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            constructors = new WrappedCollection<ClassConstructorWithCodeAnalysis, PartialClassConstructorWithCodeAnalysis>(
                classType.Constructors,
                constructor => new PartialClassConstructorWithCodeAnalysis(constructor),
                constructor => constructor.Constructor,
                value => classType.Constructors = value);
            conversionOperators = new WrappedCollection<ClassConversionOperatorWithCodeAnalysis, PartialClassConversionOperatorWithCodeAnalysis>(
                classType.ConversionOperators,
                parent => new PartialClassConversionOperatorWithCodeAnalysis(parent),
                child => child.InternalConversionOperator,
                value => classType.ConversionOperators = value);
            delegates = new WrappedCollection<ClassNestedDelegateWithCodeAnalysis, PartialClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new PartialClassNestedDelegateWithCodeAnalysis(parent),
                child => child.InternalDelegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<ClassNestedEnumWithCodeAnalysis, PartialClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new PartialClassNestedEnumWithCodeAnalysis(parent),
                child => child.InternalEnum,
                value => classType.Enums = value);
            events = new PartialClassEventCollectionWithCodeAnalysis(classType.Events);
            fields = new PartialClassFieldCollectionWithCodeAnalysis(classType.Fields);
            indexers = new PartialClassIndexerCollectionWithCodeAnalysis(classType.Indexers);
            interfaces = new WrappedCollection<ClassNestedInterfaceWithCodeAnalysis, PartialClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new PartialClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.InternalInterface,
                value => classType.Interfaces = value);
            operatorOverloads = new WrappedCollection<ClassOperatorOverloadWithCodeAnalysis, PartialClassOperatorOverloadWithCodeAnalysis>(
                classType.OperatorOverloads,
                parent => new PartialClassOperatorOverloadWithCodeAnalysis(parent),
                child => child.InternalOperatorOverload,
                value => classType.OperatorOverloads = value);
            properties = new PartialClassPropertyCollectionWithCodeAnalysis(classType.Properties);
            structs = new PartialClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
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

        public override PartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.StaticClasses), value.StaticClasses.Select(item => item.Syntax)));
            }
        }

        public override ICollection<PartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { constructors.Replace(value); }
        }

        public override ICollection<PartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { conversionOperators.Replace(value); }
        }

        public override ICollection<PartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { delegates.Replace(value); }
        }

        public override PartialClassDestructorWithCodeAnalysis Destructor
        {
            get
            {
                ClassDestructorWithCodeAnalysis destructor = classType.Destructor;
                return destructor == null ? null : new PartialClassDestructorWithCodeAnalysis(destructor);
            }
            set { classType.Destructor = value?.InternalDestructor; }
        }

        public override ICollection<PartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { enums.Replace(value); }
        }

        public override PartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.ExplicitInterfaceEvents), value.ExplicitInterfaceEvents.Select(@event => @event.Syntax)));
            }
        }

        public override PartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override PartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax)));
            }
        }

        public override ICollection<PartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.Replace(value); }
        }

        public override PartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<PartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { operatorOverloads.Replace(value); }
        }

        public override PartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(property => property.Syntax)));
            }
        }

        public override PartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get
            {
                ClassStaticConstructorWithCodeAnalysis constructor = classType.StaticConstructor;
                return constructor == null ? null : new PartialClassStaticConstructorWithCodeAnalysis(constructor);
            }
            set { classType.StaticConstructor = value?.InternalStaticConstructor; }
        }

        public override PartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }
    }
}
