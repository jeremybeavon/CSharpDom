using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedAbstractClass));
        }
    }
}
