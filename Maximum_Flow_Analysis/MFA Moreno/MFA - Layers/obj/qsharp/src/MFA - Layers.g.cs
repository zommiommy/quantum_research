#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a qubit to use to store a mark bit and a register corresponding\",\" to a database, marks the first qubit conditioned on the register\",\" state being the all-ones state |11…1〉.\",\"\",\" # Input\",\" ## markedQubit\",\" A qubit to be targeted by an `X` operation controlled on whether\",\" the state of `databaseRegister` corresponds to a market item.\",\" ## databaseRegister\",\" A register representing the target of a query to the database.\",\"\",\" # Remarks\",\" Implements the operation\",\"\",\"     |z〉 |k〉 ↦ |z ⊕ f(k)〉 |k〉,\",\"\",\" where f(k) = 1 if and only if k = 2^(Length(databaseRegister)) - 1 and\",\" 0 otherwise.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":95}},\"Documentation\":[\"automatically generated QsAdjoint specialization for MFA.DatabaseOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":95}},\"Documentation\":[\"automatically generated QsControlled specialization for MFA.DatabaseOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":95}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for MFA.DatabaseOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" a uniform superposition over all computational basis states.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsAdjoint specialization for MFA.UniformSuperpositionOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsControlled specialization for MFA.UniformSuperpositionOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for MFA.UniformSuperpositionOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" the start state |1〉|N-1〉/√N + |0〉(|0〉+|1〉+...+|N-2〉)/√N.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicates whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":94},\"Item2\":{\"Line\":1,\"Column\":103}},\"Documentation\":[\"automatically generated QsAdjoint specialization for MFA.StatePreparationOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":94},\"Item2\":{\"Line\":1,\"Column\":103}},\"Documentation\":[\"automatically generated QsControlled specialization for MFA.StatePreparationOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":94},\"Item2\":{\"Line\":1,\"Column\":103}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for MFA.StatePreparationOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflection `RM` about the marked state.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":171,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflection about the |00…0〉 state.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":171,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":186,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflection `RS` about the start state DU|0〉|0〉.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":186,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Prepares the start state and boosts the amplitude of the marked\",\" subspace by a sequence of reflections about the marked state and the\",\" start state.\",\"\",\" # Input\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":250,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked element and returns an index\",\" to the found element in binary format. Finds the marked element with\",\" probability sin²((2*nIterations+1) sin⁻¹(1/√N)).\",\"\",\" # Input\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":250,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracleTest\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":276,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Checks whether state preparation marks the right fraction of elements\",\" against theoretical predictions.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"StatePreparationOracleTest\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":276,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"GroverHardCodedTest\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":307,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked element and checks whether\",\" the success probability matches theoretical predictions. Then checks\",\" whether the correct index is found, post-selected on success.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverHardCodedTest\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":307,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":386,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":96}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Database oracle `D` constructed from classical database.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements the oracle D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉 used in the Grover\",\" search algorithm. Given a database with N = 2^n elements, n is the\",\" size of the database qubit register. Let x = x₀x₁...x_{N-1} be a\",\" binary string of N elements. Then xₖ is 1 if k is in \\\"markedElements\\\"\",\" and 0 otherwise.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":388,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":400,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":401,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":402,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":428,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Preparation of start state from database oracle and oracle `U` that\",\" creates a uniform superposition over database indices.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\" ## startQubits\",\" The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`\",\" initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements an oracle `DU` that prepares the start state\",\" DU|0〉|0〉 = √(M/N)|1〉|marked〉 + √(1-(M/N)^2)|0〉|unmarked〉 where\",\" `M` is the length of `markedElements`, and\",\" `N` is 2^n, where `n` is the number of database qubits.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":430,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":441,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":442,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":443,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":459,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Oracles\",\"Name\":\"StateOracle\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}]}}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" `StateOracle` type for the preparation of a start state that has a\",\" marked qubit entangled with some desired state in the database\",\" register.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\"\",\" # Output\",\" A `StateOracle` type with signature\",\" ((Int, Qubit[]) => ()is Adj + Ctl).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":459,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":485,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Grover's search algorithm using library functions.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of iterations of the Grover iteration to apply.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\"\",\" # Output\",\" Unitary implementing Grover's search algorithm.\",\"\",\" # Remarks\",\" On input |0〉|0〉, this prepares the state |1〉|marked〉 with amplitude\",\" Sin((2*nIterations + 1) ArcSin(Sqrt(M/N))).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":485,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":508,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked elements and returns an index\",\" to the found element in integer format.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register converted to an integer.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs\",\"Position\":{\"Item1\":508,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace MFA
{
    public partial class DatabaseOracle : Unitary<(Qubit,IQArray<Qubit>)>, ICallable
    {
        public DatabaseOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracle";
        String ICallable.FullName => "MFA.DatabaseOracle";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 80 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((databaseRegister, markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((databaseRegister, markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (databaseRegister, markedQubit)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (databaseRegister, markedQubit)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracle, (Qubit,IQArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public partial class UniformSuperpositionOracle : Unitary<IQArray<Qubit>>, ICallable
    {
        public UniformSuperpositionOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UniformSuperpositionOracle";
        String ICallable.FullName => "MFA.UniformSuperpositionOracle";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var databaseRegister = __in__;
#line 110 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var databaseRegister = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,databaseRegister) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,databaseRegister) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<UniformSuperpositionOracle, IQArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public partial class StatePreparationOracle : Unitary<(Qubit,IQArray<Qubit>)>, ICallable
    {
        public StatePreparationOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "StatePreparationOracle";
        String ICallable.FullName => "MFA.StatePreparationOracle";
        protected IUnitary<(Qubit,IQArray<Qubit>)> DatabaseOracle
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> UniformSuperpositionOracle
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 141 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            UniformSuperpositionOracle.Apply(databaseRegister);
#line 142 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            DatabaseOracle.Apply((markedQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line hidden
            DatabaseOracle.Adjoint.Apply((markedQubit, databaseRegister));
#line hidden
            UniformSuperpositionOracle.Adjoint.Apply(databaseRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line hidden
            UniformSuperpositionOracle.Controlled.Apply((__controlQubits__, databaseRegister));
#line hidden
            DatabaseOracle.Controlled.Apply((__controlQubits__, (markedQubit, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line hidden
            DatabaseOracle.Adjoint.Controlled.Apply((__controlQubits__, (markedQubit, databaseRegister)));
#line hidden
            UniformSuperpositionOracle.Adjoint.Controlled.Apply((__controlQubits__, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DatabaseOracle = this.Factory.Get<IUnitary<(Qubit,IQArray<Qubit>)>>(typeof(DatabaseOracle));
            this.UniformSuperpositionOracle = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(UniformSuperpositionOracle));
        }

        public override IApplyData __dataIn((Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<StatePreparationOracle, (Qubit,IQArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public partial class ReflectMarked : Operation<Qubit, QVoid>, ICallable
    {
        public ReflectMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectMarked";
        String ICallable.FullName => "MFA.ReflectMarked";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicR1
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var markedQubit = __in__;
#line 163 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumIntrinsicR1.Apply((MicrosoftQuantumMathPI.Apply(QVoid.Instance), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit)
        {
            return __m__.Run<ReflectMarked, Qubit, QVoid>(markedQubit);
        }
    }

    public partial class ReflectZero : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectZero";
        String ICallable.FullName => "MFA.ReflectZero";
        protected ICallable MicrosoftQuantumArraysHead
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysRest
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var databaseRegister = __in__;
#line 173 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, databaseRegister));
#line 174 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(databaseRegister), MicrosoftQuantumArraysHead.Apply<Qubit>(databaseRegister)));
#line 175 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Head<>));
            this.MicrosoftQuantumArraysRest = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Rest<>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectZero, IQArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public partial class ReflectStart : Operation<(Qubit,IQArray<Qubit>), QVoid>, ICallable
    {
        public ReflectStart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ReflectStart";
        String ICallable.FullName => "MFA.ReflectStart";
        protected ICallable<IQArray<Qubit>, QVoid> ReflectZero
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,IQArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 188 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            StatePreparationOracle.Adjoint.Apply((markedQubit, databaseRegister));
#line 189 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            ReflectZero.Apply(QArray<Qubit>.Add(new QArray<Qubit>(markedQubit), databaseRegister));
#line 190 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            StatePreparationOracle.Apply((markedQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectZero = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectZero));
            this.StatePreparationOracle = this.Factory.Get<IUnitary<(Qubit,IQArray<Qubit>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn((Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectStart, (Qubit,IQArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public partial class QuantumSearch : Operation<(Int64,Qubit,IQArray<Qubit>), QVoid>, ICallable
    {
        public QuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumSearch";
        String ICallable.FullName => "MFA.QuantumSearch";
        protected ICallable<Qubit, QVoid> ReflectMarked
        {
            get;
            set;
        }

        protected ICallable<(Qubit,IQArray<Qubit>), QVoid> ReflectStart
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,IQArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (nIterations,markedQubit,databaseRegister) = __in__;
#line 222 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            StatePreparationOracle.Apply((markedQubit, databaseRegister));
#line 225 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            foreach (var idx in new Range(0L, (nIterations - 1L)))
#line hidden
            {
#line 226 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                ReflectMarked.Apply(markedQubit);
#line 227 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                ReflectStart.Apply((markedQubit, databaseRegister));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectMarked = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(ReflectMarked));
            this.ReflectStart = this.Factory.Get<ICallable<(Qubit,IQArray<Qubit>), QVoid>>(typeof(ReflectStart));
            this.StatePreparationOracle = this.Factory.Get<IUnitary<(Qubit,IQArray<Qubit>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn((Int64,Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 nIterations, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<QuantumSearch, (Int64,Qubit,IQArray<Qubit>), QVoid>((nIterations, markedQubit, databaseRegister));
        }
    }

    public partial class ApplyQuantumSearch : Operation<(Int64,Int64), (Result,IQArray<Result>)>, ICallable
    {
        public ApplyQuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,IQArray<Result>)>, IApplyData
        {
            public Out((Result,IQArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyQuantumSearch";
        String ICallable.FullName => "MFA.ApplyQuantumSearch";
        protected ICallable<(Int64,Qubit,IQArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysForEach
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Result,IQArray<Result>)> Body => (__in__) =>
        {
            var (nIterations,nDatabaseQubits) = __in__;
#line hidden
            {
#line 254 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                var (markedQubit,databaseRegister) = (Allocate.Apply(), Allocate.Apply(nDatabaseQubits));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 256 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    QuantumSearch.Apply((nIterations, markedQubit, databaseRegister));
#line 259 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    var resultSuccess = MicrosoftQuantumMeasurementMResetZ.Apply(markedQubit);
#line 263 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    var resultElement = (IQArray<Result>)MicrosoftQuantumArraysForEach.Apply<IQArray<Result>>((MicrosoftQuantumMeasurementMResetZ, databaseRegister));
#line 266 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    return (resultSuccess, resultElement);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(markedQubit);
#line hidden
                    Release.Apply(databaseRegister);
                }
            }
        }

        ;
        public override void Init()
        {
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,IQArray<Qubit>), QVoid>>(typeof(QuantumSearch));
            this.MicrosoftQuantumArraysForEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.ForEach<,>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,IQArray<Result>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,IQArray<Result>)> Run(IOperationFactory __m__, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyQuantumSearch, (Int64,Int64), (Result,IQArray<Result>)>((nIterations, nDatabaseQubits));
        }
    }

    public partial class StatePreparationOracleTest : Operation<QVoid, QVoid>, ICallable
    {
        public StatePreparationOracleTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePreparationOracleTest";
        String ICallable.FullName => "MFA.StatePreparationOracleTest";
        protected IUnitary<(Qubit,IQArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,Double,String,Double)> MicrosoftQuantumIntrinsicAssertProb
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 278 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            foreach (var nDatabaseQubits in new Range(0L, 5L))
#line hidden
            {
#line hidden
                {
#line 279 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    var (markedQubit,databaseRegister) = (Allocate.Apply(), Allocate.Apply(nDatabaseQubits));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 280 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        StatePreparationOracle.Apply((markedQubit, databaseRegister));
#line 286 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        var successAmplitude = (1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(2L.Pow(nDatabaseQubits))));
#line 287 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        var successProbability = (successAmplitude * successAmplitude);
#line 288 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        MicrosoftQuantumIntrinsicAssertProb.Apply((new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(markedQubit), Result.One, successProbability, "Error: Success probability does not match theory", 1E-10D));
#line 292 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(markedQubit);
#line 293 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(databaseRegister);
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(markedQubit);
#line hidden
                        Release.Apply(databaseRegister);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.StatePreparationOracle = this.Factory.Get<IUnitary<(Qubit,IQArray<Qubit>)>>(typeof(StatePreparationOracle));
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicAssertProb = this.Factory.Get<IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Intrinsic.AssertProb));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<StatePreparationOracleTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class GroverHardCodedTest : Operation<QVoid, QVoid>, ICallable
    {
        public GroverHardCodedTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverHardCodedTest";
        String ICallable.FullName => "MFA.GroverHardCodedTest";
        protected ICallable<(Int64,Qubit,IQArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Result,Result,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactR
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,Double,String,Double)> MicrosoftQuantumIntrinsicAssertProb
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathArcSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Result>> MicrosoftQuantumMeasurementMultiM
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 310 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            foreach (var nDatabaseQubits in new Range(0L, 4L))
#line hidden
            {
#line 312 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                foreach (var nIterations in new Range(0L, 5L))
#line hidden
                {
#line hidden
                    {
#line 314 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                        var (markedQubit,databaseRegister) = (Allocate.Apply(), Allocate.Apply(nDatabaseQubits));
#line hidden
                        Exception __arg1__ = null;
                        try
                        {
#line 315 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            QuantumSearch.Apply((nIterations, markedQubit, databaseRegister));
#line 316 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            var successAmplitude = MicrosoftQuantumMathSin.Apply((MicrosoftQuantumConvertIntAsDouble.Apply(((2L * nIterations) + 1L)) * MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(2L.Pow(nDatabaseQubits)))))));
#line 317 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            var successProbability = (successAmplitude * successAmplitude);
#line 318 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            MicrosoftQuantumIntrinsicAssertProb.Apply((new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(markedQubit), Result.One, successProbability, "Error: Success probability does not match theory", 1E-10D));
#line 322 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            var result = MicrosoftQuantumIntrinsicM.Apply(markedQubit);
#line 324 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            if ((result == Result.One))
                            {
#line 325 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                                var results = (IQArray<Result>)MicrosoftQuantumMeasurementMultiM.Apply(databaseRegister);
#line 329 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                                foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
#line hidden
                                {
#line 330 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                                    MicrosoftQuantumDiagnosticsEqualityFactR.Apply((results[idxResult], Result.One, "Found state should be 1..1 string."));
                                }
                            }

#line 334 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            MicrosoftQuantumIntrinsicResetAll.Apply(databaseRegister);
#line 335 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                            MicrosoftQuantumIntrinsicReset.Apply(markedQubit);
                        }
#line hidden
                        catch (Exception __arg2__)
                        {
                            __arg1__ = __arg2__;
                            throw __arg1__;
                        }
#line hidden
                        finally
                        {
                            if (__arg1__ != null)
                            {
                                throw __arg1__;
                            }

#line hidden
                            Release.Apply(markedQubit);
#line hidden
                            Release.Apply(databaseRegister);
                        }
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,IQArray<Qubit>), QVoid>>(typeof(QuantumSearch));
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsEqualityFactR = this.Factory.Get<ICallable<(Result,Result,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactR));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicAssertProb = this.Factory.Get<IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Intrinsic.AssertProb));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcSin));
            this.MicrosoftQuantumMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sin));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
            this.MicrosoftQuantumMeasurementMultiM = this.Factory.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(Microsoft.Quantum.Measurement.MultiM));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<GroverHardCodedTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class DatabaseOracleFromInts : Unitary<(IQArray<Int64>,Qubit,IQArray<Qubit>)>, ICallable
    {
        public DatabaseOracleFromInts(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Int64>,Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracleFromInts";
        String ICallable.FullName => "MFA.DatabaseOracleFromInts";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line 390 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            var nMarked = markedElements.Length;
#line 392 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 397 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Apply((databaseRegister, new QArray<Qubit>(markedQubit)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Int64>,Qubit,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Adjoint.Apply((databaseRegister, new QArray<Qubit>(markedQubit)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Int64>,Qubit,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Controlled.Apply((__controlQubits__, (databaseRegister, new QArray<Qubit>(markedQubit))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Int64>,Qubit,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicX, __arg1__))))).Adjoint.Controlled.Apply((__controlQubits__, (databaseRegister, new QArray<Qubit>(markedQubit))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracleFromInts, (IQArray<Int64>,Qubit,IQArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public partial class GroverStatePrepOracleImpl : Unitary<(IQArray<Int64>,Int64,IQArray<Qubit>)>, ICallable
    {
        public GroverStatePrepOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Int64>,Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GroverStatePrepOracleImpl";
        String ICallable.FullName => "MFA.GroverStatePrepOracleImpl";
        protected IUnitary<(IQArray<Int64>,Qubit,IQArray<Qubit>)> DatabaseOracleFromInts
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysExclude
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in__;
#line 432 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 433 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            var databaseRegister = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(idxMarkedQubit), startQubits));
#line 436 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, databaseRegister));
#line 439 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            DatabaseOracleFromInts.Apply((markedElements, flagQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Int64>,Int64,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(idxMarkedQubit), startQubits));
#line hidden
            DatabaseOracleFromInts.Adjoint.Apply((markedElements, flagQubit, databaseRegister));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Int64>,Int64,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(idxMarkedQubit), startQubits));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, databaseRegister)));
#line hidden
            DatabaseOracleFromInts.Controlled.Apply((__controlQubits__, (markedElements, flagQubit, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Int64>,Int64,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = (IQArray<Qubit>)MicrosoftQuantumArraysExclude.Apply<IQArray<Qubit>>((new QArray<Int64>(idxMarkedQubit), startQubits));
#line hidden
            DatabaseOracleFromInts.Adjoint.Controlled.Apply((__controlQubits__, (markedElements, flagQubit, databaseRegister)));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DatabaseOracleFromInts = this.Factory.Get<IUnitary<(IQArray<Int64>,Qubit,IQArray<Qubit>)>>(typeof(DatabaseOracleFromInts));
            this.MicrosoftQuantumArraysExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Exclude<>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Int64 idxMarkedQubit, IQArray<Qubit> startQubits)
        {
            return __m__.Run<GroverStatePrepOracleImpl, (IQArray<Int64>,Int64,IQArray<Qubit>), QVoid>((markedElements, idxMarkedQubit, startQubits));
        }
    }

    public partial class GroverStatePrepOracle : Function<IQArray<Int64>, Microsoft.Quantum.Oracles.StateOracle>, ICallable
    {
        public GroverStatePrepOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverStatePrepOracle";
        String ICallable.FullName => "MFA.GroverStatePrepOracle";
        protected IUnitary<(IQArray<Int64>,Int64,IQArray<Qubit>)> GroverStatePrepOracleImpl
        {
            get;
            set;
        }

        protected ICallable<IUnitary, Microsoft.Quantum.Oracles.StateOracle> MicrosoftQuantumOraclesStateOracle
        {
            get;
            set;
        }

        public override Func<IQArray<Int64>, Microsoft.Quantum.Oracles.StateOracle> Body => (__in__) =>
        {
            var markedElements = __in__;
#line 462 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            return new Microsoft.Quantum.Oracles.StateOracle(GroverStatePrepOracleImpl.Partial(new Func<(Int64,IQArray<Qubit>), (IQArray<Int64>,Int64,IQArray<Qubit>)>((__arg1__) => (markedElements, __arg1__.Item1, __arg1__.Item2))));
        }

        ;
        public override void Init()
        {
            this.GroverStatePrepOracleImpl = this.Factory.Get<IUnitary<(IQArray<Int64>,Int64,IQArray<Qubit>)>>(typeof(GroverStatePrepOracleImpl));
            this.MicrosoftQuantumOraclesStateOracle = this.Factory.Get<ICallable<IUnitary, Microsoft.Quantum.Oracles.StateOracle>>(typeof(Microsoft.Quantum.Oracles.StateOracle));
        }

        public override IApplyData __dataIn(IQArray<Int64> data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Oracles.StateOracle data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Oracles.StateOracle> Run(IOperationFactory __m__, IQArray<Int64> markedElements)
        {
            return __m__.Run<GroverStatePrepOracle, IQArray<Int64>, Microsoft.Quantum.Oracles.StateOracle>(markedElements);
        }
    }

    public partial class GroverSearch : Function<(IQArray<Int64>,Int64,Int64), IUnitary>, ICallable
    {
        public GroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((IQArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GroverSearch";
        String ICallable.FullName => "MFA.GroverSearch";
        protected ICallable<IQArray<Int64>, Microsoft.Quantum.Oracles.StateOracle> GroverStatePrepOracle
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Oracles.StateOracle,Int64), IUnitary> MicrosoftQuantumAmplitudeAmplificationAmpAmpByOracle
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Int64,Int64), IUnitary> Body => (__in__) =>
        {
            var (markedElements,nIterations,idxMarkedQubit) = __in__;
#line 488 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
            return MicrosoftQuantumAmplitudeAmplificationAmpAmpByOracle.Apply((nIterations, GroverStatePrepOracle.Apply(markedElements), idxMarkedQubit));
        }

        ;
        public override void Init()
        {
            this.GroverStatePrepOracle = this.Factory.Get<ICallable<IQArray<Int64>, Microsoft.Quantum.Oracles.StateOracle>>(typeof(GroverStatePrepOracle));
            this.MicrosoftQuantumAmplitudeAmplificationAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Oracles.StateOracle,Int64), IUnitary>>(typeof(Microsoft.Quantum.AmplitudeAmplification.AmpAmpByOracle));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Int64 nIterations, Int64 idxMarkedQubit)
        {
            return __m__.Run<GroverSearch, (IQArray<Int64>,Int64,Int64), IUnitary>((markedElements, nIterations, idxMarkedQubit));
        }
    }

    public partial class ApplyGroverSearch : Operation<(IQArray<Int64>,Int64,Int64), (Result,Int64)>, ICallable
    {
        public ApplyGroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((IQArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Int64)>, IApplyData
        {
            public Out((Result,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyGroverSearch";
        String ICallable.FullName => "MFA.ApplyGroverSearch";
        protected ICallable<(IQArray<Int64>,Int64,Int64), IUnitary> GroverSearch
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysForEach
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, Int64> MicrosoftQuantumConvertResultArrayAsInt
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Int64,Int64), (Result,Int64)> Body => (__in__) =>
        {
            var (markedElements,nIterations,nDatabaseQubits) = __in__;
#line hidden
            {
#line 512 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                var (markedQubit,databaseRegister) = (Allocate.Apply(), Allocate.Apply(nDatabaseQubits));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 514 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    GroverSearch.Apply((markedElements, nIterations, 0L)).Apply(QArray<Qubit>.Add(new QArray<Qubit>(markedQubit), databaseRegister));
#line 517 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    var resultSuccess = MicrosoftQuantumMeasurementMResetZ.Apply(markedQubit);
#line 522 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA%20Moreno/MFA%20-%20Layers/MFA%20-%20Layers.qs"
                    return (resultSuccess, MicrosoftQuantumConvertResultArrayAsInt.Apply(MicrosoftQuantumArraysForEach.Apply<IQArray<Result>>((MicrosoftQuantumMeasurementMResetZ, databaseRegister))));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(markedQubit);
#line hidden
                    Release.Apply(databaseRegister);
                }
            }
        }

        ;
        public override void Init()
        {
            this.GroverSearch = this.Factory.Get<ICallable<(IQArray<Int64>,Int64,Int64), IUnitary>>(typeof(GroverSearch));
            this.MicrosoftQuantumArraysForEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.ForEach<,>));
            this.MicrosoftQuantumConvertResultArrayAsInt = this.Factory.Get<ICallable<IQArray<Result>, Int64>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsInt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, IQArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyGroverSearch, (IQArray<Int64>,Int64,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits));
        }
    }
}