using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
