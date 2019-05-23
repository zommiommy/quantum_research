function gate_decomp(in)
  
  I = eye(2);
  
  if isequal(rows(in),4) && isequal(columns(in),4)
    inverse_kron(in,H,1)
    inverse_kron(in,H,2)
    inverse_kron(in,X,1)
    inverse_kron(in,X,2)
    inverse_kron(in,Y,1)
    inverse_kron(in,Y,2)
    inverse_kron(in,Z,1)
    inverse_kron(in,Z,2)
    inverse_kron(in,I,1)
    inverse_kron(in,I,2)
  else
    display("Input matrix is not 4x4")
    return;
  endif
endfunction
