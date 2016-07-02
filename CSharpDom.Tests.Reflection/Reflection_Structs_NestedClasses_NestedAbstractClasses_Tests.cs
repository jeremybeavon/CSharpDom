using CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedAbstractClass));
        }
    }
}
