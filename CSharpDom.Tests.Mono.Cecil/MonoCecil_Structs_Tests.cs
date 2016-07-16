using CSharpDom.TestTarget.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithExplicitConversionOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithImplicitConversionOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithPrivateIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithPublicIndexerUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestInternalStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(InternalStruct));
        }

        [TestMethod]
        public async Task TestPublicStructUsingMonoCecil()
        {
            await TestStructAsync(typeof(PublicStruct));
        }
    }
}
