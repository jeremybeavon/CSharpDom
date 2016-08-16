using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Internal.Hiding
{
    internal sealed class IndexerSignature :
        AbstractIndexer<
            AttributeGroupNotSupported,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            ParameterSignature,
            AccessorSignature>
    {
        private readonly IReadOnlyList<ParameterSignature> parameters;
        private readonly AssemblyWithCodeAnalysis assembly;
        
        public IndexerSignature(AssemblyWithCodeAnalysis assembly, PropertyDefinition indexer)
        {
            this.assembly = assembly;
            parameters = indexer.Parameters.ToArray(parameter => new ParameterSignature(assembly, parameter));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override AccessorSignature GetAccessor
        {
            get { return AccessorSignature.Default; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return ReturnTypeSignature.GetReturnType(assembly); }
        }

        public override IReadOnlyList<ParameterSignature> Parameters
        {
            get { return parameters; }
        }

        public override AccessorSignature SetAccessor
        {
            get { return AccessorSignature.Default; }
        }
    }
}
