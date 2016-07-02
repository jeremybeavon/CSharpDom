using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedStaticClass));
        }
    }
}
