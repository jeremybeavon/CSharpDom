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
            TestStructAsync(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestStructWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestStructWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithExplicitConversionOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestStructWithImplicitConversionOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestInternalStructUsingReflection()
        {
            TestStructAsync(typeof(InternalStruct));
        }

        [TestMethod]
        public void TestPublicStructUsingReflection()
        {
            TestStructAsync(typeof(PublicStruct));
        }
    }
}
