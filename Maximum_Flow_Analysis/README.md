# Quantum Max Flow Min Cut Algorithm
On the paper "Quantum Algorithm Implementations for Beginners" there is no implementation of the complete algorithm of the max flow algorithm, so i am studying the paper "QUANTUM MAX-FLOW/MIN-CUT" (1508.04644.pdf) written by SHAWN X. CUI, MICHAEL H. FREEDMAN, OR SATTATH,RICHARD STONG and GREG MINTON in order to understand the actual state of art for this algorithm.

I had some issues in understanding that paper, because it works on "tensor networks", which i had no idea of what do they are.

It seemd that tensor networks often rely on the concept of local Hamiltonian. An explanation of it was on paper 1401.3916.pdf.

Tensor networks were defined on 1306.2164.pdf, "A Practical Introduction to Tensor Networks: Matrix Product States and Projected Entangled Pair States" which helped me in understanding what are tensor networks. Anyway, i found that the examples shown on this paper were very counterintuitive and from contexts very different from information technologies' concepts (GHZ state, one-dimensional cluster state, AKLT model, Majumdar-Gosh model), so i haven't deeply understood how do they work. I am still looking for some other explanations of those networks, but i am out of luck at finding other papers at the moment.

In the end, i have finished reading "QUANTUM MAX-FLOW/MIN-CUT" paper without fully understanding it. What i have understood is that the quantum algorithm relies on tensor networks and that they have nothing in common with classical algorithms for max flow problems except for some of the theorems on which max flow/min cut algorithms rely on. It seemd to me that the quantum MF/MC algorithm works for some special cases and not for general graphs.

Quantum MF/MC algorithm also requires some extra classical preprocessing, like in many other algorithms.

At the moment i am at a dead point, because i cannot understand how tensor networks can be linked with quantum algorithms. Paper "QUANTUM MAX-FLOW/MIN-CUT" does not provide me any practical help on understanding how this could be developed on a quantum computer, and it seems that both version of the algorithm shown on that paper are based on conjectures which have been proven to be true only on some particular cases.
