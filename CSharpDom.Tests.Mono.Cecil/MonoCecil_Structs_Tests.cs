using CSharpDom.TestTarget.Structs;
using CSharpDom.TestTarget.Structs.ConversionOperators;
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
            TestStruct(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWith1GenericParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStruct(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWith2GenericParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStruct(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithExplicitConversionOperatorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestStructWithImplicitConversionOperatorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestInternalStructUsingMonoCecil()
        {
            TestStruct(typeof(InternalStruct));
        }

        [TestMethod]
        public void TestPublicStructUsingMonoCecil()
        {
            TestStruct(typeof(PublicStruct));
        }
    }
}
