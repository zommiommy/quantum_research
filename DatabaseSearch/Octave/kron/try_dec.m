# try all decompositions

I = eye(4);

gate_decomp(swap_rows(I,1,2))
gate_decomp(swap_rows(I,1,3))
gate_decomp(swap_rows(I,1,4))
gate_decomp(swap_rows(I,2,3))
gate_decomp(swap_rows(I,2,4))
gate_decomp(swap_rows(I,3,4))