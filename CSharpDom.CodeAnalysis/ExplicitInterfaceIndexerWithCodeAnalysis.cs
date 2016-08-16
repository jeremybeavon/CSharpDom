using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfaceIndexerWithCodeAnalysis :
        AbstractExplicitInterfaceIndexer<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AccessorWithCodeAnalysis>
    {
        private readonly IndexerWithCodeAnalysis indexer;
        private readonly InterfaceReferenceWithCodeAnalysis explicitInterface;

        internal ExplicitInterfaceIndexerWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            this.indexer = new IndexerWithCodeAnalysis(declaringType, indexer);
            TypeReference interfaceType = indexer.Method().FindExplicitInterface();
            explicitInterface = new InterfaceReferenceWithCodeAnalysis(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return indexer.GetAccessor; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override IReadOnlyList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return indexer.SetAccessor; }
        }
    }
}
