using CSharpDom.TestTarget.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithExplicitConversionOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestStructWithImplicitConversionOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithPrivateIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithPublicIndexerUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicIndexer));
        }

        [TestMethod]
        public void TestInternalStructUsingMonoCecil()
        {
            TestStructAsync(typeof(InternalStruct));
        }

        [TestMethod]
        public void TestPublicStructUsingMonoCecil()
        {
            TestStructAsync(typeof(PublicStruct));
        }
    }
}
