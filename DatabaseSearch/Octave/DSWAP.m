function out = DSWAP
  # Double swap
  #{
  out = [
  0, 1, 0, 0;
  1, 0, 0, 0;
  0, 0, 0, 1;
  0, 0, 1, 0;
  ];
  #}
  out = kron(eye(2), X);
endfunction
