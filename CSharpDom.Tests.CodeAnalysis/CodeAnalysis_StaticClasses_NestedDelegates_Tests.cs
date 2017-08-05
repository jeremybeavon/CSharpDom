using CSharpDom.TestTarget.StaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedDelegate));
        }
    }
}
