#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":63,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" Given a qubit to use to store a mark bit and a register corresponding\",\" to a database, marks the first qubit conditioned on the register\",\" state being the all-ones state |11…1〉.\",\"\",\" # Input\",\" ## markedQubit\",\" A qubit to be targeted by an `X` operation controlled on whether\",\" the state of `databaseRegister` corresponds to a marked item.\",\" ## databaseRegister\",\" A register representing the target of a query to the database.\",\"\",\" # Remarks\",\" Implements the operation\",\"\",\"     |z〉 |k〉 ↦ |z ⊕ f(k)〉 |k〉,\",\"\",\" where f(k) = 1 if and only if k = 2^(Length(databaseRegister)) - 1 and\",\" 0 otherwise.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":65,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":72,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"UniformSuperposition\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":89,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" a uniform superposition over all computational basis states.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"UniformSuperposition\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":91,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"UniformSuperposition\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":99,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparation\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":117,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" the start state |1〉|N-1〉/√N + |0〉(|0〉+|1〉+...+|N-2〉)/√N.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicates whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparation\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":119,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparation\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":124,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Reflection `RM` about the marked state.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"XAll\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":152,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"XAll\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":152,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Reflection about the |00…0〉 state.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of 1+n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":187,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Reflection `RS` about the start state DU|0〉|0〉.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":187,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Prepares the start state and boosts the amplitude of the marked\",\" subspace by a sequence of reflections about the marked state and the\",\" start state.\",\"\",\" # Input\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":249,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked element and returns an index\",\" to the found element in binary format. Finds the marked element with\",\" probability sin²((2*nIterations+1) sin⁻¹(1/√N)).\",\"\",\" # Input\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":249,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":329,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":96}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Database oracle `D` constructed from classical database.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements the oracle D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉 used in the Grover\",\" search algorithm. xₖ is 1 if k is in \\\"markedElements\\\" and 0 otherwise.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":331,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":343,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":344,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":345,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":371,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Preparation of start state from database oracle and oracle `U` that\",\" creates a uniform superposition over database indices.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\" ## startQubits\",\" The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`\",\" initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements an oracle `DU` that prepares the start state\",\" DU|0〉|0〉 = √(M/N)|1〉|marked〉 + √(1-(M/N)^2)|0〉|unmarked〉 where\",\" `M` is the length of `markedElements`, and\",\" `N` is 2^n, where `n` is the number of database qubits.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":373,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":384,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":385,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":386,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":402,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"StateOracle\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}]}}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" `StateOracle` type for the preparation of a start state that has a\",\" marked qubit entangled with some desired state in the database\",\" register.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\"\",\" # Output\",\" A `StateOracle` type with signature\",\" ((Int, Qubit[]) => (): Adjoint, Controlled).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":402,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":428,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Grover's search algorithm using library functions.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of iterations of the Grover iteration to apply.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\"\",\" # Output\",\" Unitary implementing Grover's search algorithm.\",\"\",\" # Remarks\",\" On input |0〉|0〉, this prepares the state |1〉|marked〉 with amplitude\",\" Sin((2*nIterations + 1) ArcSin(Sqrt(M/N))).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":428,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":451,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked elements and returns an index\",\" to the found element in integer format.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register converted to an integer.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":451,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace Microsoft.Quantum.Samples.DatabaseSearch
{
    public class DatabaseOracle : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracle";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 70 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((databaseRegister?.Copy(), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((databaseRegister?.Copy(), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracle, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class UniformSuperposition : Adjointable<QArray<Qubit>>, ICallable
    {
        public UniformSuperposition(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UniformSuperposition";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.UniformSuperposition";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var databaseRegister = __in__;
#line 93 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var nQubits = databaseRegister.Length;
#line 95 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 96 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveH.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var databaseRegister = __in__;
#line hidden
            var nQubits = databaseRegister.Length;
#line hidden
            foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<UniformSuperposition, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class StatePreparation : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public StatePreparation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "StatePreparation";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.StatePreparation";
        protected IAdjointable<(Qubit,QArray<Qubit>)> DatabaseOracle
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> UniformSuperposition
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 121 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            UniformSuperposition.Apply(databaseRegister?.Copy());
#line 122 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            DatabaseOracle.Apply((markedQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line hidden
            DatabaseOracle.Adjoint.Apply((markedQubit, databaseRegister?.Copy()));
#line hidden
            UniformSuperposition.Adjoint.Apply(databaseRegister?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DatabaseOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(DatabaseOracle));
            this.UniformSuperposition = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(UniformSuperposition));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<StatePreparation, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class ReflectMarked : Operation<Qubit, QVoid>, ICallable
    {
        public ReflectMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectMarked";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectMarked";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var markedQubit = __in__;
#line 147 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveR1.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit)
        {
            return __m__.Run<ReflectMarked, Qubit, QVoid>(markedQubit);
        }
    }

    public class XAll : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public XAll(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "XAll";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.XAll";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var databaseRegister = __in__;
#line 155 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var nQubits = databaseRegister.Length;
#line 157 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 158 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<XAll, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class ReflectZero : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ReflectZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectZero";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectZero";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> XAll
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var databaseRegister = __in__;
#line 170 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var nQubits = databaseRegister.Length;
#line 172 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            XAll.Apply(databaseRegister?.Copy());
#line 174 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((databaseRegister?.Slice(new Range(1L, (nQubits - 1L))), databaseRegister[0L]));
#line 176 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            XAll.Apply(databaseRegister?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
            this.XAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(XAll));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectZero, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class ReflectStart : Operation<(Qubit,QArray<Qubit>), QVoid>, ICallable
    {
        public ReflectStart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ReflectStart";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectStart";
        protected ICallable<QArray<Qubit>, QVoid> ReflectZero
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparation
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 190 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            StatePreparation.Adjoint.Apply((markedQubit, databaseRegister?.Copy()));
#line 191 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            ReflectZero.Apply((new QArray<Qubit>()
            {markedQubit} + databaseRegister));
#line 192 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            StatePreparation.Apply((markedQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectZero = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(ReflectZero));
            this.StatePreparation = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(StatePreparation));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectStart, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class QuantumSearch : Operation<(Int64,Qubit,QArray<Qubit>), QVoid>, ICallable
    {
        public QuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.QuantumSearch";
        protected ICallable<Qubit, QVoid> ReflectMarked
        {
            get;
            set;
        }

        protected ICallable<(Qubit,QArray<Qubit>), QVoid> ReflectStart
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparation
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (nIterations,markedQubit,databaseRegister) = __in__;
#line 222 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            StatePreparation.Apply((markedQubit, databaseRegister?.Copy()));
#line 225 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            foreach (var idx in new Range(0L, (nIterations - 1L)))
#line hidden
            {
#line 226 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                ReflectMarked.Apply(markedQubit);
#line 227 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                ReflectStart.Apply((markedQubit, databaseRegister?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectMarked = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(ReflectMarked));
            this.ReflectStart = this.Factory.Get<ICallable<(Qubit,QArray<Qubit>), QVoid>>(typeof(ReflectStart));
            this.StatePreparation = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(StatePreparation));
        }

        public override IApplyData __dataIn((Int64,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 nIterations, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<QuantumSearch, (Int64,Qubit,QArray<Qubit>), QVoid>((nIterations, markedQubit, databaseRegister));
        }
    }

    public class ApplyQuantumSearch : Operation<(Int64,Int64), (Result,QArray<Result>)>, ICallable
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

        public class Out : QTuple<(Result,QArray<Result>)>, IApplyData
        {
            public Out((Result,QArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyQuantumSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyQuantumSearch";
        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(Int64,Qubit,QArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Result,QArray<Result>)> Body => (__in__) =>
        {
            var (nIterations,nDatabaseQubits) = __in__;
#line 253 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var resultSuccess = Result.Zero;
#line 254 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var resultElement = new QArray<Result>(nDatabaseQubits);
#line hidden
            {
#line 257 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 260 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    var markedQubit = qubits[0L];
#line 263 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 266 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    QuantumSearch.Apply((nIterations, markedQubit, databaseRegister?.Copy()));
#line 269 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    resultSuccess = M.Apply(markedQubit);
#line 273 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 277 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    if ((resultSuccess == Result.One))
                    {
#line 278 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                        MicrosoftQuantumPrimitiveX.Apply(markedQubit);
                    }

#line 281 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
#line hidden
                    {
#line 283 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                        if ((resultElement[idxResult] == Result.One))
                        {
#line 284 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                            MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxResult]);
                        }
                    }
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
                    Release.Apply(qubits);
                }
            }

#line 290 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            return (resultSuccess, resultElement?.Copy());
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,QArray<Qubit>), QVoid>>(typeof(QuantumSearch));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,QArray<Result>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,QArray<Result>)> Run(IOperationFactory __m__, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyQuantumSearch, (Int64,Int64), (Result,QArray<Result>)>((nIterations, nDatabaseQubits));
        }
    }

    public class DatabaseOracleFromInts : Unitary<(QArray<Int64>,Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracleFromInts(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracleFromInts";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracleFromInts";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line 333 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var nMarked = markedElements.Length;
#line 335 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 340 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Apply((databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Adjoint.Apply((databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Controlled.Apply((__controlQubits__?.Copy(), (databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit})));
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
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracleFromInts, (QArray<Int64>,Qubit,QArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public class GroverStatePrepOracleImpl : Unitary<(QArray<Int64>,Int64,QArray<Qubit>)>, ICallable
    {
        public GroverStatePrepOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GroverStatePrepOracleImpl";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracleImpl";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonExclude
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)> DatabaseOracleFromInts
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in__;
#line 375 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 376 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line 379 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line 382 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            DatabaseOracleFromInts.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            DatabaseOracleFromInts.Adjoint.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            DatabaseOracleFromInts.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            DatabaseOracleFromInts.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.DatabaseOracleFromInts = this.Factory.Get<IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)>>(typeof(DatabaseOracleFromInts));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 idxMarkedQubit, QArray<Qubit> startQubits)
        {
            return __m__.Run<GroverStatePrepOracleImpl, (QArray<Int64>,Int64,QArray<Qubit>), QVoid>((markedElements, idxMarkedQubit, startQubits));
        }
    }

    public class GroverStatePrepOracle : Function<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>, ICallable
    {
        public GroverStatePrepOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverStatePrepOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracle";
        protected IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)> GroverStatePrepOracleImpl
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> Body => (__in__) =>
        {
            var markedElements = __in__;
#line 405 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            return new Microsoft.Quantum.Canon.StateOracle(GroverStatePrepOracleImpl.Partial(new Func<(Int64,QArray<Qubit>), (QArray<Int64>,Int64,QArray<Qubit>)>((__arg1__) => (markedElements?.Copy(), __arg1__.Item1, __arg1__.Item2))));
        }

        ;
        public override void Init()
        {
            this.GroverStatePrepOracleImpl = this.Factory.Get<IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)>>(typeof(GroverStatePrepOracleImpl));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.StateOracle data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.StateOracle> Run(IOperationFactory __m__, QArray<Int64> markedElements)
        {
            return __m__.Run<GroverStatePrepOracle, QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>(markedElements);
        }
    }

    public class GroverSearch : Function<(QArray<Int64>,Int64,Int64), IUnitary>, ICallable
    {
        public GroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GroverSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverSearch";
        protected ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary> MicrosoftQuantumCanonAmpAmpByOracle
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> GroverStatePrepOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), IUnitary> Body => (__in__) =>
        {
            var (markedElements,nIterations,idxMarkedQubit) = __in__;
#line 431 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            return MicrosoftQuantumCanonAmpAmpByOracle.Apply((nIterations, GroverStatePrepOracle.Apply(markedElements), idxMarkedQubit));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOracle));
            this.GroverStatePrepOracle = this.Factory.Get<ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>>(typeof(GroverStatePrepOracle));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 idxMarkedQubit)
        {
            return __m__.Run<GroverSearch, (QArray<Int64>,Int64,Int64), IUnitary>((markedElements, nIterations, idxMarkedQubit));
        }
    }

    public class ApplyGroverSearch : Operation<(QArray<Int64>,Int64,Int64), (Result,Int64)>, ICallable
    {
        public ApplyGroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
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
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyGroverSearch";
        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonPositiveIntFromResultArr
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,Int64,Int64), IUnitary> GroverSearch
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), (Result,Int64)> Body => (__in__) =>
        {
            var (markedElements,nIterations,nDatabaseQubits) = __in__;
#line 455 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var resultSuccess = Result.Zero;
#line 456 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            var numberElement = 0L;
#line hidden
            {
#line 460 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 463 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    var markedQubit = qubits[0L];
#line 466 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 469 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    GroverSearch.Apply((markedElements?.Copy(), nIterations, 0L)).Apply(qubits?.Copy());
#line 472 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    resultSuccess = M.Apply(markedQubit);
#line 476 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    var resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 477 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    numberElement = MicrosoftQuantumCanonPositiveIntFromResultArr.Apply(resultElement);
#line 481 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
                    ResetAll.Apply(qubits?.Copy());
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
                    Release.Apply(qubits);
                }
            }

#line 485 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\src\\DatabaseSearch\\DatabaseSearch.qs"
            return (resultSuccess, numberElement);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonPositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GroverSearch = this.Factory.Get<ICallable<(QArray<Int64>,Int64,Int64), IUnitary>>(typeof(GroverSearch));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyGroverSearch, (QArray<Int64>,Int64,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits));
        }
    }
}