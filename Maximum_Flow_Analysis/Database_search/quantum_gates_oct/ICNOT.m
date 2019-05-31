function out = ICNOT
  # Inverted CNOT
  out = DSWAP * CNOT;
  #{
  out = [
  0, 1, 0, 0;
  1, 0, 0, 0;
  0, 0, 1, 0;
  0, 0, 0, 1;
  ];
  #}
endfunction
