using CSharpDom.TestTarget.Classes.NestedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedDelegate));
        }
    }
}
