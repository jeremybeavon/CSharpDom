using CSharpDom.TestTarget.Classes.NestedStructs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedAbstractClass));
        }
    }
}
