using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructPropertyCollectionWithCodeAnalysis :
        EditableStructPropertyCollection<StructPropertyWithCodeAnalysis, ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<
            PropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> explicitInterfaceProperties;
        private readonly StructTypeMemberListWrapper<
            PropertyWithCodeAnalysis,
            StructPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;

        internal StructPropertyCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            explicitInterfaceProperties = new StructTypeMemberListWrapper<PropertyWithCodeAnalysis, ExplicitInterfacePropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                structType.Node,
                () => new ExplicitInterfacePropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            properties = new StructTypeMemberListWrapper<PropertyWithCodeAnalysis, StructPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                structType.Node,
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

        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> ExplicitInterfacePropertyList
        {
            get { return explicitInterfaceProperties; }
        }

        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> PropertyList
        {
            get { return properties; }
        }
    }
}
