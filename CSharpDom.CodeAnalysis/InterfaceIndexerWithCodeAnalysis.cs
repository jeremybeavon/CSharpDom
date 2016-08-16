using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceIndexerWithCodeAnalysis :
        AbstractInterfaceIndexer<
            AttributeGroupWithCodeAnalysis,
            IBasicTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            InterfaceAccessorWithCodeAnalysis>
    {
        private readonly PropertyDefinition indexer;
        private readonly IBasicTypeWithCodeAnalysis declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis indexerType;
        private readonly InterfaceAccessorWithCodeAnalysis getAccessor;
        private readonly InterfaceAccessorWithCodeAnalysis setAccessor;
        private readonly Lazy<Parameters<IndexerParameterWithCodeAnalysis>> parameters;

        internal InterfaceIndexerWithCodeAnalysis(IBasicTypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            this.indexer = indexer;
            this.declaringType = declaringType;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, indexer));
            indexerType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, indexer.PropertyType, indexer);
            parameters = new Lazy<Parameters<IndexerParameterWithCodeAnalysis>>(
                () => new Parameters<IndexerParameterWithCodeAnalysis>(assembly, indexer, parameter => new IndexerParameterWithCodeAnalysis(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithCodeAnalysis(assembly, indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithCodeAnalysis(assembly, indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IBasicTypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override InterfaceAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexerType; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if ((indexer.GetMethod ?? indexer.SetMethod).IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }

        public override IReadOnlyList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public override InterfaceAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
