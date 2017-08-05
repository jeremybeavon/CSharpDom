using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithInternalMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithOverrideMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithPrivateMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithProtectedMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithPublicMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithStaticMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithVirtualMethodUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
