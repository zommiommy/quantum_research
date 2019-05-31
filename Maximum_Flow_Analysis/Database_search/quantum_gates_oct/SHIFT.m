function out = SHIFT
  # Changes top half matrix with bottom half
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
