using CSharpDom.TestTarget.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithExplicitConversionOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithImplicitConversionOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithPrivateIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithPublicIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestInternalStructUsingReflection()
        {
            await TestStructAsync(typeof(InternalStruct));
        }

        [TestMethod]
        public async Task TestPublicStructUsingReflection()
        {
            await TestStructAsync(typeof(PublicStruct));
        }
    }
}
