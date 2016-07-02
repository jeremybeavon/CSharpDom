using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
