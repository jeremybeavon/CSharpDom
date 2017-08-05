using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
