using CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedAbstractClass));
        }
    }
}
