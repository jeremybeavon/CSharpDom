using CSharpDom.TestTarget.Structs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithInternalNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithPrivateNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithPublicNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicNestedAbstractClass));
        }
    }
}
