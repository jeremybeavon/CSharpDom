using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class ConstructorNodeWithReflection : ConstructorNodeWithSymbols, IConstructorWithReflection
    {
        private const BindingFlags Flags = ReflectionMemberHelper.Flags;
        private ConstructorInfo constructorInfo;

        public ConstructorNodeWithReflection(
            ConstructorDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public ConstructorInfo ConstructorInfo
        {
            get
            {
                if (constructorInfo == null)
                {
                    ImmutableArray<IParameterSymbol> parameters = Symbol.Parameters;
                    ConstructorInfo[] constructors = ((IHasType)DeclaringType).Type.GetConstructors(Flags)
                        .Where(constructor => ReflectionMemberHelper.IsMatch(constructor.GetParameters(), parameters))
                        .ToArray();
                    constructorInfo = ReflectionMemberHelper.ValidateMember(constructors);
                }

                return constructorInfo;
            }
        }

        public IConstructorWithSymbols Symbols
        {
            get { return this; }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
