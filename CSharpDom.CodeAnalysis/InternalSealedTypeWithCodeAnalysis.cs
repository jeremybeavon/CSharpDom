using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalSealedTypeWithCodeAnalysis<TClass> : SealedTypeWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly SealedClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            ClassConstructorWithCodeAnalysis,
            SealedClassConstructorWithCodeAnalysis> constructors;
        private readonly WrappedCollection<
            ClassConversionOperatorWithCodeAnalysis,
            SealedClassConversionOperatorWithCodeAnalysis> conversionOperators;
        private readonly WrappedCollection<
            ClassNestedDelegateWithCodeAnalysis,
            SealedClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            ClassNestedEnumWithCodeAnalysis,
            SealedClassNestedEnumWithCodeAnalysis> enums;
        private readonly SealedClassEventCollectionWithCodeAnalysis events;
        private readonly SealedClassFieldCollectionWithCodeAnalysis fields;
        private readonly SealedClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly WrappedCollection<
            ClassNestedInterfaceWithCodeAnalysis,
            SealedClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly SealedClassMethodCollectionWithCodeAnalysis methods;
        private readonly WrappedCollection<
            ClassOperatorOverloadWithCodeAnalysis,
            SealedClassOperatorOverloadWithCodeAnalysis> operatorOverloads;
        private readonly SealedClassPropertyCollectionWithCodeAnalysis properties;
        private readonly SealedClassNestedStructCollectionWithCodeAnalysis structs;

        internal InternalSealedTypeWithCodeAnalysis(TClass @class)
        {
            classType = new InternalClassTypeWithCodeAnalysis<TClass>(@class);
            members = classType.Members;
            classes = new SealedClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            constructors = new WrappedCollection<ClassConstructorWithCodeAnalysis, SealedClassConstructorWithCodeAnalysis>(
                classType.Constructors,
                constructor => new SealedClassConstructorWithCodeAnalysis(constructor),
                constructor => constructor.Constructor,
                value => classType.Constructors = value);
            conversionOperators = new WrappedCollection<ClassConversionOperatorWithCodeAnalysis, SealedClassConversionOperatorWithCodeAnalysis>(
                classType.ConversionOperators,
                parent => new SealedClassConversionOperatorWithCodeAnalysis(parent),
                child => child.ConversionOperator,
                value => classType.ConversionOperators = value);
            delegates = new WrappedCollection<ClassNestedDelegateWithCodeAnalysis, SealedClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new SealedClassNestedDelegateWithCodeAnalysis(parent),
                child => child.Delegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<ClassNestedEnumWithCodeAnalysis, SealedClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new SealedClassNestedEnumWithCodeAnalysis(parent),
                child => child.Enum,
                value => classType.Enums = value);
            events = new InternalSealedClassEventCollectionWithCodeAnalysis<TClass>(classType);
            fields = new SealedClassFieldCollectionWithCodeAnalysis(classType.Fields);
            indexers = new InternalSealedClassIndexerCollectionWithCodeAnalysis<TClass>(classType);
            interfaces = new WrappedCollection<ClassNestedInterfaceWithCodeAnalysis, SealedClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new SealedClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            methods = new InternalSealedClassMethodCollectionWithCodeAnalysis<TClass>(classType);
            operatorOverloads = new WrappedCollection<ClassOperatorOverloadWithCodeAnalysis, SealedClassOperatorOverloadWithCodeAnalysis>(
                classType.OperatorOverloads,
                parent => new SealedClassOperatorOverloadWithCodeAnalysis(parent),
                child => child.OperatorOverload,
                value => classType.OperatorOverloads = value);
            properties = new InternalSealedClassPropertyCollectionWithCodeAnalysis<TClass>(classType);
            structs = new SealedClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
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

        public override SealedClassNestedClassCollectionWithCodeAnalysis Classes
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

        public override ICollection<SealedClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { constructors.Replace(value); }
        }

        public override ICollection<SealedClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { conversionOperators.Replace(value); }
        }

        public override ICollection<SealedClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { delegates.Replace(value); }
        }

        public override SealedClassDestructorWithCodeAnalysis Destructor
        {
            get
            {
                ClassDestructorWithCodeAnalysis destructor = classType.Destructor;
                return destructor == null ? null : new SealedClassDestructorWithCodeAnalysis(destructor);
            }
            set { classType.Destructor = value?.Destructor; }
        }

        public override ICollection<SealedClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { enums.Replace(value); }
        }

        public override SealedClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.ExplicitInterfaceEvents), value.ExplicitInterfaceEvents.Select(@event => @event.Syntax)));
            }
        }

        public override SealedClassFieldCollectionWithCodeAnalysis Fields
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

        public override SealedClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax)));
            }
        }

        public override ICollection<SealedClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.Replace(value); }
        }

        public override SealedClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(method => method.Syntax)),
                    new MemberListSyntax(nameof(methods.ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(method => method.Syntax)));
            }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<SealedClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { operatorOverloads.Replace(value); }
        }

        public override SealedClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(property => property.Syntax)));
            }
        }

        public override SealedClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get
            {
                ClassStaticConstructorWithCodeAnalysis constructor = classType.StaticConstructor;
                return constructor == null ? null : new SealedClassStaticConstructorWithCodeAnalysis(constructor);
            }
            set { classType.StaticConstructor = value?.StaticConstructor; }
        }

        public override SealedClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }

        public override ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override ClassTypeWithCodeAnalysis Class => classType;

        internal InternalClassTypeWithCodeAnalysis<TClass> Type
        {
            get { return classType; }
        }

        internal override INode<ClassDeclarationSyntax> Node => classType.Node;

        private void InitializeMembers()
        {
            members.Replace(nameof(events.Events), () => events.Events.Select(item => item.Syntax));
            members.Replace(nameof(events.EventProperties), () => events.EventProperties.Select(item => item.Syntax));
            members.Replace(nameof(indexers.Indexers), () => indexers.Indexers.Select(item => item.Syntax));
            members.Replace(nameof(methods.Methods), () => methods.Methods.Select(item => item.Syntax));
            members.Replace(nameof(properties.Properties), () => properties.Properties.Select(item => item.Syntax));
        }
    }
}
