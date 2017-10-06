using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InternalStructPropertyCollectionWithCodeAnalysis<TStruct> :
        StructPropertyCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            ExplicitInterfacePropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> explicitInterfaceProperties;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;

        internal InternalStructPropertyCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            explicitInterfaceProperties = new StructTypeMemberListWrapper<TStruct, ExplicitInterfacePropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                structType.InternalNode,
                () => new ExplicitInterfacePropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            properties = new StructTypeMemberListWrapper<TStruct, StructPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                structType.InternalNode,
                () => new StructPropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
            set { structType.Members.CombineList(nameof(ExplicitInterfaceProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { structType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }
    }
}
