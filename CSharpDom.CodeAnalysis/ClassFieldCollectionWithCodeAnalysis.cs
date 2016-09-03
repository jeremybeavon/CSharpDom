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
        private readonly ClassMemberListWrapper<
            ConstantGroupWithCodeAnalysis,
            ClassConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly ClassMemberListWrapper<
            FieldGroupWithCodeAnalysis,
            ClassFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;

        internal ClassFieldCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            constants = new ClassMemberListWrapper<ConstantGroupWithCodeAnalysis, ClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                classType.Node,
                parent => new ClassConstantWithCodeAnalysis(parent),
                (child, parent) => child.Constant.ClassParent = parent,
                syntax => syntax.Modifiers.Any(SyntaxKind.ConstKeyword));
            fields = new ClassMemberListWrapper<FieldGroupWithCodeAnalysis, ClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                classType.Node,
                parent => new ClassFieldWithCodeAnalysis(parent),
                (child, parent) => child.Field.ClassParent = parent,
                syntax => !syntax.Modifiers.Any(SyntaxKind.ConstKeyword));
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

        internal IChildCollection<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> ConstantList
        {
            get { return constants; }
        }

        internal IChildCollection<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> FieldList
        {
            get { return fields; }
        }
    }
}
