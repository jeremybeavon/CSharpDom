using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedDelegate));
        }
    }
}
