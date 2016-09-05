using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassPropertyCollectionWithCodeAnalysis :
        EditableAbstractClassPropertyCollection<
            ClassPropertyWithCodeAnalysis,
            AbstractPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassPropertyListWrapper<ClassPropertyWithCodeAnalysis> properties;
        private readonly ClassPropertyListWrapper<AbstractPropertyWithCodeAnalysis> abstractProperties;

        internal AbstractClassPropertyCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<ClassPropertyWithCodeAnalysis>(
                classType.Node,
                parent => new ClassPropertyWithCodeAnalysis(parent, ClassType.Normal),
                (child, parent) => child.Property.Property.SetClassParent(parent, ClassType.Normal),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractProperties = new ClassPropertyListWrapper<AbstractPropertyWithCodeAnalysis>(
                classType.Node,
                parent => new AbstractPropertyWithCodeAnalysis(parent),
                (child, parent) => child.Property.AbstractClassParent = parent,
                syntax => syntax.Modifiers.IsAbstract());
        }

        public override ICollection<AbstractPropertyWithCodeAnalysis> AbstractProperties
        {
            get { return abstractProperties; }
            set { }
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return classType.Properties.ExplicitInterfaceProperties; }
            set { classType.Properties.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<ClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
        }
        
        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> AbstractPropertyList
        {
            get { return abstractProperties; }
        }

        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> PropertyList
        {
            get { return properties; }
        }
    }
}
