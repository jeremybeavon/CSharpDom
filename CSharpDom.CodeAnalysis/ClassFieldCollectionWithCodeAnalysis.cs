using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<ClassFieldWithCodeAnalysis, ClassConstantWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<ClassConstantWithCodeAnalysis, FieldDeclarationSyntax> constants;
        private readonly ClassMemberListWrapper<ClassFieldWithCodeAnalysis, FieldDeclarationSyntax> fields;

        internal ClassFieldCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            constants = new ClassMemberListWrapper<ClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                classType.Node,
                () => new ClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new ClassMemberListWrapper<ClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                classType.Node,
                () => new ClassFieldWithCodeAnalysis(),
                syntax => !syntax.IsConstant());
        }
        
        public override ICollection<ClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { classType.Members.CombineList(nameof(Constants), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { classType.Members.CombineList(nameof(Fields), value.Select(item => item.Syntax)); }
        }
    }
}
