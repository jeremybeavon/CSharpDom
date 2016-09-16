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
        private readonly ClassPropertyListWrapper<ExplicitInterfacePropertyWithCodeAnalysis> explicitInterfaceProperties;
        private readonly ClassPropertyListWrapper<ClassPropertyWithCodeAnalysis> properties;

        internal ClassPropertyCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            explicitInterfaceProperties = new ClassPropertyListWrapper<ExplicitInterfacePropertyWithCodeAnalysis>(
                classType.Node,
                () => new ExplicitInterfacePropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            properties = new ClassPropertyListWrapper<ClassPropertyWithCodeAnalysis>(
                classType.Node,
                () => new ClassPropertyWithCodeAnalysis(),
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
    }
}
