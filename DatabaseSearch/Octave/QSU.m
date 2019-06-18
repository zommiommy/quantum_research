function out = QSU
  # quarter shift up
  out = CNOT*SWAP*ICNOT;
endfunction
