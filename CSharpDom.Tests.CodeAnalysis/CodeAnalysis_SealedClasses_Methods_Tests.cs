using CSharpDom.TestTarget.SealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticMethodUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticMethod));
        }
    }
}
