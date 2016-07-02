using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedAbstractClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedAbstractClass));
        }
    }
}
