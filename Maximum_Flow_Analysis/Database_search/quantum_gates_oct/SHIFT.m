function out = SHIFT
  display("SHIFT");
  #{
  out = [
  0, 1, 0, 0;
  1, 0, 0, 0;
  0, 0, 0, 1;
  0, 0, 1, 0;
  ];
  #}
  
  out = kron(X, eye(2));
endfunction
