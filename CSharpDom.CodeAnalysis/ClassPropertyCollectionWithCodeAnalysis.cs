using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassPropertyCollectionWithCodeAnalysis :
        EditableClassPropertyCollection<ClassPropertyWithCodeAnalysis, ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<
            PropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> explicitInterfaceProperties;
        private readonly ClassMemberListWrapper<
            PropertyWithCodeAnalysis,
            ClassPropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;

        internal ClassPropertyCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            explicitInterfaceProperties = new ClassMemberListWrapper<PropertyWithCodeAnalysis, ExplicitInterfacePropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                classType.Node,
                parent => new ExplicitInterfacePropertyWithCodeAnalysis(parent),
                (child, parent) => child.Property.Property.ExplicitInterfaceClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            properties = new ClassMemberListWrapper<PropertyWithCodeAnalysis, ClassPropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                classType.Node,
                parent => new ClassPropertyWithCodeAnalysis(parent),
                (child, parent) => child.Property.Property.ClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
            set { classType.Members.CombineList(nameof(ExplicitInterfaceProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
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
