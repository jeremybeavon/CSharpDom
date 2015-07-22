﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassBody : CodeGenerationNode
    {
        public ClassBody()
        {
            Fields = new Collection<ClassFieldDeclaration>();
            Events = new Collection<ClassEvent>();
            Properties = new Collection<ClassProperty>();
            Indexers = new Collection<ClassIndexer>();
            Methods = new Collection<ClassMethod>();
            UnaryOperators = new Collection<UnaryOperator>();
            BinaryOperators = new Collection<BinaryOperator>();
            ConversionOperators = new Collection<ConversionOperator>();
            NestedClasses = new Collection<ClassNestedClass>();
            NestedDelegates = new Collection<ClassNestedDelegate>();
            NestedEnums = new Collection<ClassNestedEnum>();
        }

        public Collection<ClassFieldDeclaration> Fields { get; set; }

        public Collection<ClassEvent> Events { get; set; }

        public Collection<ClassProperty> Properties { get; set; }

        public Collection<ClassIndexer> Indexers { get; set; }

        public Collection<ClassMethod> Methods { get; set; }

        public Collection<UnaryOperator> UnaryOperators { get; set; }

        public Collection<BinaryOperator> BinaryOperators { get; set; }

        public Collection<ConversionOperator> ConversionOperators { get; set; }

        public Collection<ClassNestedClass> NestedClasses { get; set; }

        public Collection<ClassNestedDelegate> NestedDelegates { get; set; }

        public Collection<ClassNestedEnum> NestedEnums { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}