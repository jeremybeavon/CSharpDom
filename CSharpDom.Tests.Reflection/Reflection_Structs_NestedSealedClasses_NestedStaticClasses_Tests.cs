using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedStaticClass));
        }
    }
}
