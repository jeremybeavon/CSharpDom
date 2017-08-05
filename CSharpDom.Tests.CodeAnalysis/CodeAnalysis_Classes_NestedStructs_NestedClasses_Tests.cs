using CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedClass));
        }
    }
}
