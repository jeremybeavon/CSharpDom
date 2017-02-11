using CSharpDom.TestTarget.Structs;
using CSharpDom.TestTarget.Structs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestStructWith1ImplementedInterfaceUsingReflection()
        {
            TestStruct(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestStructWith2ImplementedInterfacesUsingReflection()
        {
            TestStruct(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithExplicitConversionOperatorUsingReflection()
        {
            TestStruct(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestStructWithImplicitConversionOperatorUsingReflection()
        {
            TestStruct(typeof(StructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestInternalStructUsingReflection()
        {
            TestStruct(typeof(InternalStruct));
        }

        [TestMethod]
        public void TestPublicStructUsingReflection()
        {
            TestStruct(typeof(PublicStruct));
        }
    }
}
