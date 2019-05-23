function out = ICNOT
  #display("ICNOT");
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
