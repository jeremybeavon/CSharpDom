using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractTypeWithCodeAnalysis :
        EditableAbstractType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AbstractClassEventCollectionWithCodeAnalysis,
            AbstractClassPropertyCollectionWithCodeAnalysis,
            AbstractClassIndexerCollectionWithCodeAnalysis,
            AbstractClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            IClassNestedClassCollection,
            IClassNestedDelegate,
            IClassNestedEnum,
            IClassNestedInterfaceCollection,
            IClassNestedStructCollection,
            IStaticConstructor>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly AbstractClassEventCollectionWithCodeAnalysis events;
        private readonly AbstractClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly AbstractClassMethodCollectionWithCodeAnalysis methods;
        private readonly AbstractClassPropertyCollectionWithCodeAnalysis properties;

        private AbstractTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            events = new AbstractClassEventCollectionWithCodeAnalysis(classType);
            indexers = new AbstractClassIndexerCollectionWithCodeAnalysis(classType);
            methods = new AbstractClassMethodCollectionWithCodeAnalysis(classType);
            properties = new AbstractClassPropertyCollectionWithCodeAnalysis(classType);
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

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        internal ClassTypeWithCodeAnalysis Type
        {
            get { return classType; }
        }
    }
}
