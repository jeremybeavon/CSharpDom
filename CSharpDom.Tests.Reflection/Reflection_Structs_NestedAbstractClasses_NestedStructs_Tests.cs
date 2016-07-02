using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicNestedStructUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedStruct));
        }
    }
}
