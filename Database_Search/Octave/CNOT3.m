function out = CNOT3
  display("kron(CNOT,I)");
  out = kron(CNOT, eye(2));
endfunction
