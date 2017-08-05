using CSharpDom.TestTarget.AbstractClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedDelegate));
        }
    }
}
